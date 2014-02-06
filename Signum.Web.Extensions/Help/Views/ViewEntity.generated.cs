﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Extensions.Help.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Engine.Help;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 7 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Entities.Basics;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Entities.Reflection;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    #line 5 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Help\Views\ViewEntity.cshtml"
    using Signum.Web.Help;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Help/Views/ViewEntity.cshtml")]
    public partial class ViewEntity : System.Web.Mvc.WebViewPage<dynamic>
    {
        public ViewEntity()
        {
        }
        public override void Execute()
        {
DefineSection("head", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Help\Views\ViewEntity.cshtml"
Write(Html.ScriptCss("~/help/Content/help.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

            
            #line 12 "..\..\Help\Views\ViewEntity.cshtml"
   Html.RenderPartial(HelpClient.Menu);
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Help\Views\ViewEntity.cshtml"
   EntityHelp eh = (EntityHelp)Model;
   ViewBag.Title = eh.Type.NiceName();

            
            #line default
            #line hidden
WriteLiteral("\r\n<form");

WriteAttribute("action", Tuple.Create(" action=\"", 404), Tuple.Create("\"", 447)
            
            #line 16 "..\..\Help\Views\ViewEntity.cshtml"
, Tuple.Create(Tuple.Create("", 413), Tuple.Create<System.Object, System.Int32>(HelpLogic.EntityUrl(eh.Type)
            
            #line default
            #line hidden
, 413), false)
, Tuple.Create(Tuple.Create("", 442), Tuple.Create("/Save", 442), true)
);

WriteLiteral(" id=\"form-save\"");

WriteLiteral(">\r\n<div");

WriteLiteral(" id=\"entityName\"");

WriteLiteral(">\r\n    <span");

WriteLiteral(" class=\'shortcut\'");

WriteLiteral(">[e:");

            
            #line 18 "..\..\Help\Views\ViewEntity.cshtml"
                         Write(eh.Type.Name);

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n    <h1");

WriteAttribute("title", Tuple.Create(" title=\"", 549), Tuple.Create("\"", 575)
            
            #line 19 "..\..\Help\Views\ViewEntity.cshtml"
, Tuple.Create(Tuple.Create("", 557), Tuple.Create<System.Object, System.Int32>(eh.Type.Namespace
            
            #line default
            #line hidden
, 557), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\Help\Views\ViewEntity.cshtml"
                              Write(eh.Type.NiceName());

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\Help\Views\ViewEntity.cshtml"
Write(Html.TextArea("description", eh.Description, 5, 80, new { @class = "editable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <span");

WriteLiteral(" class=\"editor\"");

WriteLiteral(" id=\"description-editor\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Help\Views\ViewEntity.cshtml"
   Write(Html.WikiParse(eh.Description, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </span>\r\n</div>\r\n<div");

WriteLiteral(" id=\"entityContent\"");

WriteLiteral(" class=\"help_left\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Help\Views\ViewEntity.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Help\Views\ViewEntity.cshtml"
     if (eh.Properties != null && eh.Properties.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"properties\"");

WriteLiteral(">\r\n            <h2>\r\n                Propiedades</h2>\r\n            <dl>\r\n");

            
            #line 32 "..\..\Help\Views\ViewEntity.cshtml"
                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Help\Views\ViewEntity.cshtml"
                   
        var a = TreeHelper.ToTreeS(eh.Properties, kvp =>
        {
            string s = kvp.Key.TryBeforeLast('.') ?? kvp.Key.TryBeforeLast('/');
            if(s == null)
                return null;

            if (s.StartsWith("[")) // Mixin
                return null;
            
            return new KeyValuePair<string, PropertyHelp>(s, eh.Properties[s]);
        });
        ViewDataDictionary vdd = new ViewDataDictionary();
        vdd.Add("EntityName", eh.Type.Name);
                
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 47 "..\..\Help\Views\ViewEntity.cshtml"
                
            
            #line default
            #line hidden
            
            #line 47 "..\..\Help\Views\ViewEntity.cshtml"
                 foreach (var node in a)
                {
                    Html.RenderPartial(HelpClient.ViewEntityPropertyUrl, node, vdd);
                }

            
            #line default
            #line hidden
WriteLiteral("            </dl>\r\n        </div>\r\n");

            
            #line 53 "..\..\Help\Views\ViewEntity.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 54 "..\..\Help\Views\ViewEntity.cshtml"
     if (eh.Queries.TryCS(queries => queries.Count > 0) != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"queries\"");

WriteLiteral(">\r\n            <h2>\r\n                Consultas</h2>\r\n            <dl>\r\n");

            
            #line 60 "..\..\Help\Views\ViewEntity.cshtml"
                
            
            #line default
            #line hidden
            
            #line 60 "..\..\Help\Views\ViewEntity.cshtml"
                 foreach (var mq in eh.Queries)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\'shortcut\'");

WriteLiteral(">[q:");

            
            #line 62 "..\..\Help\Views\ViewEntity.cshtml"
                                         Write(QueryUtils.GetQueryUniqueKey(mq.Key));

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n");

WriteLiteral("                    <dt>");

            
            #line 63 "..\..\Help\Views\ViewEntity.cshtml"
                   Write(QueryUtils.GetNiceName(mq.Key));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n");

WriteLiteral("                    <dd>\r\n                        <img");

WriteLiteral(" src=\'help/Images/table.gif\'");

WriteLiteral(" title=\'Ver columnas\'");

WriteLiteral(" style=\'float: right\'");

WriteLiteral(" onclick=\"javascript:$(this).siblings(\'.query-columns\').toggle(\'fast\');\"");

WriteLiteral(" />\r\n");

WriteLiteral("                        ");

            
            #line 66 "..\..\Help\Views\ViewEntity.cshtml"
                   Write(Html.WikiParse(mq.Value.Info, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 67 "..\..\Help\Views\ViewEntity.cshtml"
                   Write(Html.TextArea("q-" + QueryUtils.GetQueryUniqueKey(mq.Key).Replace(".", "_"), mq.Value.UserDescription, new { @class = "editable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <span");

WriteLiteral(" class=\"editor\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2677), Tuple.Create("\"", 2746)
, Tuple.Create(Tuple.Create("", 2682), Tuple.Create("q-", 2682), true)
            
            #line 68 "..\..\Help\Views\ViewEntity.cshtml"
, Tuple.Create(Tuple.Create("", 2684), Tuple.Create<System.Object, System.Int32>(QueryUtils.GetQueryUniqueKey(mq.Key).Replace(".", "_")
            
            #line default
            #line hidden
, 2684), false)
, Tuple.Create(Tuple.Create("", 2739), Tuple.Create("-editor", 2739), true)
);

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 69 "..\..\Help\Views\ViewEntity.cshtml"
                       Write(Html.WikiParse(mq.Value.UserDescription, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        <div");

WriteLiteral(" class=\'query-columns\'");

WriteLiteral(">\r\n                            <hr />\r\n                            <table");

WriteLiteral(" width=\"100%\"");

WriteLiteral(">\r\n");

            
            #line 74 "..\..\Help\Views\ViewEntity.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 74 "..\..\Help\Views\ViewEntity.cshtml"
                                 foreach (var qc in mq.Value.Columns)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <tr>\r\n                                       " +
" <td>\r\n                                            <b>");

            
            #line 78 "..\..\Help\Views\ViewEntity.cshtml"
                                          Write(qc.Value.Name.NiceName());

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n                                        </td>\r\n                            " +
"            <td> ");

            
            #line 80 "..\..\Help\Views\ViewEntity.cshtml"
                                        Write(Html.WikiParse(qc.Value.Info, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </td>\r\n                                " +
"    </tr>\r\n");

WriteLiteral("                                    <tr>\r\n                                       " +
" <td>\r\n                                        </td>\r\n                          " +
"              <td>");

            
            #line 86 "..\..\Help\Views\ViewEntity.cshtml"
                                       Write(Html.TextArea("c-" + QueryUtils.GetQueryUniqueKey(mq.Key).Replace(".", "_") + "." + qc.Key, qc.Value.UserDescription, new { @class = "editable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            <span");

WriteLiteral(" class=\"editor\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3935), Tuple.Create("\"", 4015)
, Tuple.Create(Tuple.Create("", 3940), Tuple.Create("qc-", 3940), true)
            
            #line 87 "..\..\Help\Views\ViewEntity.cshtml"
, Tuple.Create(Tuple.Create("", 3943), Tuple.Create<System.Object, System.Int32>(QueryUtils.GetQueryUniqueKey(mq.Key).Replace(".", "_") + "." + qc.Key
            
            #line default
            #line hidden
, 3943), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 88 "..\..\Help\Views\ViewEntity.cshtml"
                                           Write(Html.WikiParse(qc.Value.UserDescription, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </span>\r\n                          " +
"              </td>\r\n                                    </tr>\r\n");

            
            #line 92 "..\..\Help\Views\ViewEntity.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </table>\r\n                            <hr />\r\n       " +
"                 </div>\r\n                    </dd>\r\n");

            
            #line 97 "..\..\Help\Views\ViewEntity.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </dl>\r\n        </div>\r\n");

            
            #line 100 "..\..\Help\Views\ViewEntity.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 101 "..\..\Help\Views\ViewEntity.cshtml"
     if (eh.Operations != null && eh.Operations.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"operations\"");

WriteLiteral(">\r\n            <h2>\r\n                Operaciones</h2>\r\n            <dl>\r\n");

            
            #line 107 "..\..\Help\Views\ViewEntity.cshtml"
                
            
            #line default
            #line hidden
            
            #line 107 "..\..\Help\Views\ViewEntity.cshtml"
                 foreach (var p in eh.Operations)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\'shortcut\'");

WriteLiteral(">[o:");

            
            #line 109 "..\..\Help\Views\ViewEntity.cshtml"
                                         Write(OperationDN.UniqueKey(p.Key));

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n");

WriteLiteral("                    <dt>");

            
            #line 110 "..\..\Help\Views\ViewEntity.cshtml"
                   Write(p.Key.NiceToString());

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n");

WriteLiteral("                    <dd>\r\n");

WriteLiteral("                        ");

            
            #line 112 "..\..\Help\Views\ViewEntity.cshtml"
                   Write(Html.WikiParse(p.Value.Info, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 113 "..\..\Help\Views\ViewEntity.cshtml"
                   Write(Html.TextArea("o-" + OperationDN.UniqueKey(p.Key), p.Value.UserDescription, new { @class = "editable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <span");

WriteLiteral(" class=\"editor\"");

WriteAttribute("id", Tuple.Create(" id=\"", 5177), Tuple.Create("\"", 5238)
, Tuple.Create(Tuple.Create("", 5182), Tuple.Create("o-", 5182), true)
            
            #line 114 "..\..\Help\Views\ViewEntity.cshtml"
, Tuple.Create(Tuple.Create("", 5184), Tuple.Create<System.Object, System.Int32>(OperationDN.UniqueKey(p.Key).Replace(".", "_")
            
            #line default
            #line hidden
, 5184), false)
, Tuple.Create(Tuple.Create("", 5231), Tuple.Create("-editor", 5231), true)
);

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 115 "..\..\Help\Views\ViewEntity.cshtml"
                       Write(Html.WikiParse(p.Value.UserDescription, HelpClient.DefaultWikiSettings));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                    </dd>\r\n");

            
            #line 118 "..\..\Help\Views\ViewEntity.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </dl>\r\n        </div>\r\n");

            
            #line 121 "..\..\Help\Views\ViewEntity.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"help_right\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"sidebar\"");

WriteLiteral(">\r\n        <h3>\r\n            Temas relacionados</h3>\r\n        <ul>\r\n");

            
            #line 128 "..\..\Help\Views\ViewEntity.cshtml"
            
            
            #line default
            #line hidden
            
            #line 128 "..\..\Help\Views\ViewEntity.cshtml"
               List<Type> types = (List<Type>)ViewData["nameSpace"];
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 129 "..\..\Help\Views\ViewEntity.cshtml"
            
            
            #line default
            #line hidden
            
            #line 129 "..\..\Help\Views\ViewEntity.cshtml"
             foreach (Type t in types)
            {
                if (t != eh.Type)
                {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 5793), Tuple.Create("\"", 5823)
            
            #line 133 "..\..\Help\Views\ViewEntity.cshtml"
, Tuple.Create(Tuple.Create("", 5800), Tuple.Create<System.Object, System.Int32>(HelpLogic.EntityUrl(t)
            
            #line default
            #line hidden
, 5800), false)
);

WriteLiteral(">");

            
            #line 133 "..\..\Help\Views\ViewEntity.cshtml"
                                                 Write(t.NiceName());

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 134 "..\..\Help\Views\ViewEntity.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"type-selected\"");

WriteLiteral(">");

            
            #line 137 "..\..\Help\Views\ViewEntity.cshtml"
                                     Write(t.NiceName());

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 138 "..\..\Help\Views\ViewEntity.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"clearall\"");

WriteLiteral(">\r\n</div>\r\n</form>\r\n");

        }
    }
}
#pragma warning restore 1591
