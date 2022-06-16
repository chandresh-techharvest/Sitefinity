#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMSSample.ResourcePackages.Bootstrap5.MVC.Views.Layouts
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 1 "..\..MVC\Views\Layouts\default.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..MVC\Views\Layouts\default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\Layouts\default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Layouts\default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Layouts\default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Layouts/default.cshtml")]
    public partial class @default : System.Web.Mvc.WebViewPage<dynamic>
    {
        public @default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html ");

            
            #line 8 "..\..MVC\Views\Layouts\default.cshtml"
 Write(Html.RenderLangAttribute());

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 8 "..\..MVC\Views\Layouts\default.cshtml"
                             Write(Html.RenderDirAttribute());

            
            #line default
            #line hidden
WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..MVC\Views\Layouts\default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\Layouts\default.cshtml"
     if (Html.RenderDirAttribute().ToString() != "dir=\"rtl\"") {
        Html.StyleSheet(Url.WidgetContent("~/ResourcePackages/Bootstrap5/assets/dist/css/main.min.css"), "head", true);
    } else {
        Html.StyleSheet(Url.WidgetContent("~/ResourcePackages/Bootstrap5/assets/dist/css/main.min.rtl.css"), "head", true);
    }

            
            #line default
            #line hidden
WriteLiteral("    <title></title>\r\n</head>\r\n\r\n<body>\r\n");

WriteLiteral("    ");

            
            #line 23 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 26 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.SfPlaceHolder("Contentplaceholder1"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 30 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("inline-editing"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 31 "..\..MVC\Views\Layouts\default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\Layouts\default.cshtml"
     if (Html.ShouldRenderInlineEditing())
    {
        
            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(ScriptRef.MicrosoftAjax, "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\Layouts\default.cshtml"
                                                                     
        
            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(ScriptRef.MicrosoftAjaxCore, "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\Layouts\default.cshtml"
                                                                         
        
            
            #line default
            #line hidden
            
            #line 35 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(ScriptRef.JQuery, "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 35 "..\..MVC\Views\Layouts\default.cshtml"
                                                              

        
            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.jquery.ba-outside-events.min.js"), "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\Layouts\default.cshtml"
                                                                                                                                                                                    
        
            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(ScriptRef.KendoAll, "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\Layouts\default.cshtml"
                                                                
        
            
            #line default
            #line hidden
            
            #line 39 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(ScriptRef.KendoTimezones, "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 39 "..\..MVC\Views\Layouts\default.cshtml"
                                                                      
        
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.Script(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.RequireJS.require.min.js"), "inline-editing", true));

            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\Layouts\default.cshtml"
                                                                                                                                                                             
        
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\Layouts\default.cshtml"
   Write(Html.InlineEditingManager(false));

            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\Layouts\default.cshtml"
                                         
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 43 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 44 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("frameworks"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 45 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("plugins"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 46 "..\..MVC\Views\Layouts\default.cshtml"
Write(Html.Section("bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591