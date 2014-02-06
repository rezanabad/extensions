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

namespace Signum.Web.Extensions.Cache.Views
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
    
    #line 2 "..\..\Cache\Views\Statistics.cshtml"
    using Signum.Engine.Cache;
    
    #line default
    #line hidden
    using Signum.Entities;
    using Signum.Utilities;
    
    #line 1 "..\..\Cache\Views\Statistics.cshtml"
    using Signum.Utilities.ExpressionTrees;
    
    #line default
    #line hidden
    using Signum.Web;
    
    #line 3 "..\..\Cache\Views\Statistics.cshtml"
    using Signum.Web.Cache;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Cache/Views/Statistics.cshtml")]
    public partial class Statistics : System.Web.Mvc.WebViewPage<List<CachedTableBase>>
    {

#line 34 "..\..\Cache\Views\Statistics.cshtml"
public System.Web.WebPages.HelperResult ShowTree(CachedTableBase table, string prefix)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 34 "..\..\Cache\Views\Statistics.cshtml"
        

#line default
#line hidden

#line 35 "..\..\Cache\Views\Statistics.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <tr>\r\n                <td>");


#line 37 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, prefix + table.Table.Name.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n                <td>");


#line 39 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, table.Type.TypeName());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n                <td>");


#line 41 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, table.Count.TryToString() ?? "-- not loaded --");


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n                <td>");


#line 43 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, table.Hits.DefaultToNull());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n                <td>");


#line 45 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, table.Invalidations.DefaultToNull());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n                <td>");


#line 47 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, table.Loads.DefaultToNull());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n                <td>");


#line 49 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, table.SumLoadTime.NiceToString());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </td>\r\n            </tr>\r\n");


#line 52 "..\..\Cache\Views\Statistics.cshtml"
            
    if (table.SubTables != null)
    {
        foreach (var st in table.SubTables)
        {
            

#line default
#line hidden

#line 57 "..\..\Cache\Views\Statistics.cshtml"
WriteTo(__razor_helper_writer, ShowTree(st, prefix + " -> "));


#line default
#line hidden

#line 57 "..\..\Cache\Views\Statistics.cshtml"
                                          
        }
    }
        

#line default
#line hidden
});

#line 60 "..\..\Cache\Views\Statistics.cshtml"
}
#line default
#line hidden

        public Statistics()
        {
        }
        public override void Execute()
        {
WriteLiteral("<h2>");

            
            #line 5 "..\..\Cache\Views\Statistics.cshtml"
Write(ViewData[ViewDataKeys.Title]);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n<div>\r\n    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 177), Tuple.Create("\"", 233)
            
            #line 7 "..\..\Cache\Views\Statistics.cshtml"
, Tuple.Create(Tuple.Create("", 184), Tuple.Create<System.Object, System.Int32>(Url.Action((CacheController pc) => pc.Disable())
            
            #line default
            #line hidden
, 184), false)
);

WriteLiteral(" class=\"sf-button\"");

WriteAttribute("style", Tuple.Create(" \r\n        style=\"", 252), Tuple.Create("\"", 333)
            
            #line 8 "..\..\Cache\Views\Statistics.cshtml"
, Tuple.Create(Tuple.Create("", 270), Tuple.Create<System.Object, System.Int32>(!CacheLogic.GloballyDisabled ? "" : "display:none"
            
            #line default
            #line hidden
, 270), false)
, Tuple.Create(Tuple.Create("", 323), Tuple.Create(";color:red", 323), true)
);

WriteLiteral(" id=\"sfCacheDisable\"");

WriteLiteral(">Disable </a>\r\n    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 375), Tuple.Create("\"", 430)
            
            #line 9 "..\..\Cache\Views\Statistics.cshtml"
, Tuple.Create(Tuple.Create("", 382), Tuple.Create<System.Object, System.Int32>(Url.Action((CacheController pc) => pc.Enable())
            
            #line default
            #line hidden
, 382), false)
);

WriteLiteral(" class=\"sf-button\"");

WriteAttribute("style", Tuple.Create("  \r\n        style=\"", 449), Tuple.Create("\"", 520)
            
            #line 10 "..\..\Cache\Views\Statistics.cshtml"
, Tuple.Create(Tuple.Create("", 468), Tuple.Create<System.Object, System.Int32>(CacheLogic.GloballyDisabled ? "" : "display:none"
            
            #line default
            #line hidden
, 468), false)
);

WriteLiteral(" id=\"sfCacheEnable\"");

WriteLiteral(">Enable </a>\r\n    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 560), Tuple.Create("\"", 614)
            
            #line 11 "..\..\Cache\Views\Statistics.cshtml"
, Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(Url.Action((CacheController pc) => pc.Clean())
            
            #line default
            #line hidden
, 567), false)
);

WriteLiteral(" class=\"sf-button\"");

WriteLiteral(" id=\"sfCacheClear\"");

WriteLiteral(">Clean </a>\r\n</div>\r\n<table");

WriteLiteral(" class=\"sf-search-results sf-stats-table\"");

WriteLiteral(@">
    <thead>
        <tr>
            <th>Table
            </th>
            <th>Type
            </th>
            <th>Count
            </th>
            <th>Hits
            </th>
            <th>Invalidations
            </th>
            <th>Loads
            </th>
            <th>LoadTime
            </th>
        </tr>
    </thead>
    <tbody>

");

WriteLiteral("\r\n");

            
            #line 62 "..\..\Cache\Views\Statistics.cshtml"
        
            
            #line default
            #line hidden
            
            #line 62 "..\..\Cache\Views\Statistics.cshtml"
         foreach (var table in Model)
        {
            
            
            #line default
            #line hidden
            
            #line 64 "..\..\Cache\Views\Statistics.cshtml"
       Write(ShowTree(table, null));

            
            #line default
            #line hidden
            
            #line 64 "..\..\Cache\Views\Statistics.cshtml"
                                  
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(function () {\r\n");

WriteLiteral("        ");

            
            #line 70 "..\..\Cache\Views\Statistics.cshtml"
    Write(new JsFunction(CacheClient.Model, "init"));

            
            #line default
            #line hidden
WriteLiteral(";\r\n    }); \r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
