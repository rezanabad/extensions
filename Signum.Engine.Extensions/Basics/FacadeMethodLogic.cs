﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Signum.Engine.Maps;
using Signum.Entities.Authorization;
using Signum.Entities.Basics;
using System.Reflection;
using Signum.Utilities;
using Signum.Engine.DynamicQuery;
using Signum.Entities.Reflection;
using Signum.Entities;
using System.Collections.Concurrent;
using Signum.Utilities.Reflection;
using System.Diagnostics;

namespace Signum.Engine.Basics
{
    public static class FacadeMethodLogic
    {
        static HashSet<MethodInfo> methods = new HashSet<MethodInfo>();

        public static IEnumerable<MethodInfo> ServiceMethodInfos { get { return methods;  } }

        public static void Start(SchemaBuilder sb, params Type[] serviceInterface)
        {
            if (sb.NotDefined(MethodInfo.GetCurrentMethod()))
            {
                sb.Include<FacadeMethodDN>();
                sb.Schema.Synchronizing += SyncronizeServiceOperations;

                if (serviceInterface != null)
                    foreach (var t in serviceInterface)
                        Register(t);
            }
        }

        public static void Register(Type serviceInterface)
        {
            var meth = serviceInterface.GetInterfaces().PreAnd(serviceInterface).SelectMany(a => a.GetMethods()).ToArray();

            methods.AddRange(meth.Select(mi => Normalize(mi)));
        }

        public static string Key(this MethodInfo mi)
        {
            return mi.DeclaringType.Name + "." + mi.Name;
        }

        public static FacadeMethodDN RetrieveOrGenerateFacadeMethod(string facadeMethod)
        {
            MethodInfo mi = ServiceMethodInfos.Where(m => m.Key() == facadeMethod)
                .Single("Method not found in registered Service Interfaces");

            return Database.Query<FacadeMethodDN>().SingleOrDefault(a => a.Match(mi)) ?? new FacadeMethodDN(mi);
        }

        public static List<FacadeMethodDN> RetrieveOrGenerateFacadeMethods()
        {
            var current = Database.RetrieveAll<FacadeMethodDN>().ToDictionary(a => a.ToString());
            var total = GenerateFacadeMethods().ToDictionary(a => a.ToString());

            total.SetRange(current);
            return total.Values.ToList();
        }

        private static IEnumerable<FacadeMethodDN> GenerateFacadeMethods()
        {
            return methods.Select(m => new FacadeMethodDN(m));
        }

        static ConcurrentDictionary<MethodInfo, MethodInfo> normalizationCache = new ConcurrentDictionary<MethodInfo, MethodInfo>();
        public static MethodInfo Normalize(MethodInfo mi)
        {
            return normalizationCache.GetOrAdd(mi, mi2 =>
                {
                    var decType = mi2.DeclaringType;

                    if (mi2.DeclaringType.IsInterface)
                    {
                        Debug.Assert(mi2.DeclaringType == mi2.ReflectedType);
                        return mi2;
                    }

                    return (from inter in decType.GetInterfaces()
                            let map = decType.GetInterfaceMap(inter)
                            let index = map.TargetMethods.IndexOf(m => ReflectionTools.MethodEqual(m, mi2))
                            where index != -1
                            select map.InterfaceMethods[index]).Single(
                                "{0} is not an implementation of any interface".Formato(mi2.Name),
                                "{0} is implementing many interfaces".Formato(mi2.Name));
                });
        }

        const string FacadeMethodKey = "FacadeMethod";

        public static SqlPreCommand SyncronizeServiceOperations(Replacements replacements)
        {
            var should = GenerateFacadeMethods();

            var current = Administrator.TryRetrieveAll<FacadeMethodDN>(replacements);

            Table table = Schema.Current.Table<FacadeMethodDN>();

            return Synchronizer.SynchronizeReplacing(replacements, FacadeMethodKey,
                current.ToDictionary(a => a.ToString()),
                should.ToDictionary(a => a.ToString()),
                (n, c) => table.DeleteSqlSync(c),
                null,
                (fn, c, s) =>
                {
                    c.InterfaceName = s.InterfaceName;
                    c.MethodName = s.MethodName;
                    return table.UpdateSqlSync(c);
                }, Spacing.Double);
        }

        public static MethodInfo FindMethodInfo(FacadeMethodDN fm)
        {
            return methods.Single(mi => fm.Match(mi));
        }
    }
}
