﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    
    #line 5 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Engine.Translation;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Entities;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Entities.Mailing;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Entities.Translation;
    
    #line default
    #line hidden
    using Signum.Utilities;
    
    #line 6 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Web;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
    using Signum.Web.Mailing;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Mailing/Views/EmailTemplateMessage.cshtml")]
    public partial class _Mailing_Views_EmailTemplateMessage_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Mailing_Views_EmailTemplateMessage_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 9 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
 using (var ec = Html.TypeContext<EmailTemplateMessageEmbedded>())
{
    ec.LabelColumns = new BsColumn(1);

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"sf-email-template-message\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" class=\"sf-tab-title\"");

WriteAttribute("value", Tuple.Create(" value=\"", 436), Tuple.Create("\"", 479)
            
            #line 13 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
, Tuple.Create(Tuple.Create("", 444), Tuple.Create<System.Object, System.Int32>(ec.Value.CultureInfo?.ToString()
            
            #line default
            #line hidden
, 444), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
   Write(Html.EntityCombo(ec, e => e.CultureInfo, vl =>
        {
            vl.LabelText = EmailTemplateViewMessage.Language.NiceToString();
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"sf-template-message-insert-container\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
       Write(Html.QueryTokenBuilder(null, ec, MailingClient.GetQueryTokenBuilderSettings((QueryDescription)ViewData[ViewDataKeys.QueryDescription], SubTokensOptions.CanAnyAll | SubTokensOptions.CanElement)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" data-prefix=\"");

            
            #line 20 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
                                                             Write(ec.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"btn btn-default btn-sm sf-button sf-email-inserttoken sf-email-inserttoke" +
"n-basic\"");

WriteAttribute("value", Tuple.Create("  value=\"", 1077), Tuple.Create("\"", 1135)
            
            #line 20 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
                                                                                                , Tuple.Create(Tuple.Create("", 1086), Tuple.Create<System.Object, System.Int32>(EmailTemplateViewMessage.Insert.NiceToString()
            
            #line default
            #line hidden
, 1086), false)
);

WriteLiteral(" />\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" data-prefix=\"");

            
            #line 21 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
                                                             Write(ec.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"btn btn-default btn-sm sf-button sf-email-inserttoken sf-email-inserttoke" +
"n-if\"");

WriteLiteral(" data-block=\"if\"");

WriteLiteral(" value=\"if\"");

WriteLiteral(" />\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" data-prefix=\"");

            
            #line 22 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
                                                             Write(ec.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"btn btn-default btn-sm sf-button sf-email-inserttoken sf-email-inserttoke" +
"n-foreach\"");

WriteLiteral(" data-block=\"foreach\"");

WriteLiteral(" value=\"foreach\"");

WriteLiteral(" />\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" data-prefix=\"");

            
            #line 23 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
                                                             Write(ec.Prefix);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"btn btn-default btn-sm sf-button sf-email-inserttoken sf-email-inserttoke" +
"n-any\"");

WriteLiteral(" data-block=\"any\"");

WriteLiteral(" value=\"any\"");

WriteLiteral(" />\r\n        </div>\r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
   Write(Html.ValueLine(ec, e => e.Subject, vl =>
        {
            vl.FormGroupStyle = FormGroupStyle.None;
            vl.PlaceholderLabels = true;
            vl.LabelHtmlProps["style"] = "width:100px";
            vl.ValueHtmlProps["class"] = "sf-email-inserttoken-target sf-email-template-message-subject form-control";
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 32 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
   Write(Html.ValueLine(ec, e => e.Text, vl =>
        {
            vl.FormGroupStyle = FormGroupStyle.None;
            vl.ValueLineType = ValueLineType.TextArea;
            vl.ValueHtmlProps["style"] = "width:100%; height:180px;";
            vl.ValueHtmlProps["class"] = "sf-rich-text-editor sf-email-template-message-text";
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <script>\r\n            $(function () {\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
            Write(MailingClient.Module["initHtmlEditorWithTokens"](ec.SubContext(e => e.Text).Prefix, UICulture));

            
            #line default
            #line hidden
WriteLiteral(";\r\n            });\r\n        </script>\r\n    </div>\r\n");

            
            #line 46 "..\..\Mailing\Views\EmailTemplateMessage.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
