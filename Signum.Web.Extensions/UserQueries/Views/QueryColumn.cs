﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using Signum.Utilities;
    using Signum.Entities;
    using Signum.Web;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Web.DynamicData;
    using System.Web.SessionState;
    using System.Web.Profile;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Xml.Linq;
    using Signum.Engine;
    using Signum.Entities.UserQueries;
    using Signum.Web.UserQueries;
    using Signum.Entities.DynamicQuery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MvcRazorClassGenerator", "1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/UserQueries/Views/QueryColumn.cshtml")]
    public class _Page_UserQueries_Views_QueryColumn_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {


        public _Page_UserQueries_Views_QueryColumn_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {





 using (var e = Html.TypeContext<QueryColumnDN>())
{
    using (var style = e.SubContext())
    {
        style.OnlyValue = true;
        
   Write(Html.ValueLine(style, f => f.DisplayName, vl => vl.ValueHtmlProps["size"] = 20));

                                                                                        

WriteLiteral("        <div style=\"float: left\">\r\n            ");


       Write(Html.QueryTokenBuilder(e.Value.Token, e, (QueryDescription)ViewData[ViewDataKeys.QueryDescription]));

WriteLiteral("\r\n        </div>\r\n");


    }
}
WriteLiteral(" ");


        }
    }
}
