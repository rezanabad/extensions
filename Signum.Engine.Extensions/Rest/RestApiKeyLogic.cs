﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Signum.Engine.DynamicQuery;
using Signum.Engine.Maps;
using Signum.Entities.Rest;
using Signum.Engine.Operations;
using Signum.Utilities;
using System.Security.Cryptography;

namespace Signum.Engine.Rest
{
    public class RestApiKeyLogic
    {
        public static Func<string> GenerateRestApiKey = () => DefaultGenerateRestApiKey();

        public static void Start(SchemaBuilder sb, DynamicQueryManager dqm)
        {
            if (sb.NotDefined(MethodInfo.GetCurrentMethod()))
            {
                sb.Include<RestApiKeyEntity>()
                    .WithQuery(dqm, e => new
                    {
                        Entity = e,
                        e.Id,
                        e.User,
                        e.ApiKey
                    });

                new Graph<RestApiKeyEntity>.Execute(RestApiKeyOperation.Save)
                {
                    AllowsNew = true,
                    Lite = false,
                    Execute = (e, _) => { },
                }.Register();
            }
        }

        private static string DefaultGenerateRestApiKey()
        {
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[32];
                rng.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData);
            }
        }
    }
}