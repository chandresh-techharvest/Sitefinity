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

namespace CMSSample.ResourcePackages.Bootstrap4.MVC.Views.LoginForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using System.Linq.Expressions;
    
    #line default
    #line hidden
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
    
    #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Abstractions;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Security.CSRF;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/LoginForm/LoginForm.LoginForm.cshtml")]
    public partial class LoginForm_LoginForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.LoginFormViewModel>
    {

#line 98 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<LoginFormViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 99 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 122 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n");


#line 124 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        

#line default
#line hidden

#line 124 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 127 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 127 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 131 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 131 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 135 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 135 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 142 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        

#line default
#line hidden

#line 142 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 5837), Tuple.Create("\'", 5864)

#line 144 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 5842), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 5842), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"form-text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 145 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
          WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n            </div>\r\n");


#line 147 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 149 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"


#line default
#line hidden
});

#line 149 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
}
#line default
#line hidden

        public LoginForm_LoginForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
  
    var hasExternalProviders = Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0;
    var rowClass = hasExternalProviders ? "row" : "";
    var colClass = hasExternalProviders ? "col-lg-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 975), Tuple.Create("\"", 1002)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 983), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 983), false)
, Tuple.Create(Tuple.Create(" ", 998), Tuple.Create("m-0", 999), true)
);

WriteLiteral(">\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
     using (Html.BeginFormSitefinity(@Request.Url.Query, null, null, FormMethod.Post, new Dictionary<string, object> { { "role", "form" } }, true))
    {
        
            
            #line default
            #line hidden
            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                     ;
            

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1228), Tuple.Create("\"", 1245)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1236), Tuple.Create<System.Object, System.Int32>(rowClass
            
            #line default
            #line hidden
, 1236), false)
);

WriteLiteral(">\r\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1265), Tuple.Create("\"", 1282)
            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1273), Tuple.Create<System.Object, System.Int32>(colClass
            
            #line default
            #line hidden
, 1273), false)
);

WriteLiteral(">\r\n                <h3>");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("LoginFormLogInLegendHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if ((!string.IsNullOrEmpty(Request.QueryStringGet("err")) && ViewBag.ControllerId.Equals(Request.QueryStringGet("sf_login_cntrl_id"))) || Model.LoginError)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                              Write(Html.Resource("IncorrectCredentialsMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(FormGroupPanel("UserName", u => u.UserName, "LoginUserName", "text", null, new Dictionary<string, object>() { { "aria-required", "true" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(FormGroupPanel("Password", u => u.Password, "LoginPassword", "password", null, new Dictionary<string, object>() { { "aria-required", "true" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRememberMe || Model.ShowForgotPasswordLink)
                {
                    var isPulledRight = Model.ShowRememberMe ? "col-lg-6" : "col-lg-12";


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\r\n");

            
            #line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                         if (Model.ShowRememberMe)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"checkbox col-lg-6 m-0\"");

WriteLiteral(">\r\n                                <label>\r\n");

WriteLiteral("                                    ");

            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                               Write(Html.CheckBoxFor(u => u.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                               Write(Html.Resource("RememberMe"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 56 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                     if (Model.ShowForgotPasswordLink)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2809), Tuple.Create("\"", 2850)
, Tuple.Create(Tuple.Create("", 2817), Tuple.Create("text-lg-right", 2817), true)
, Tuple.Create(Tuple.Create(" ", 2830), Tuple.Create("pr-4", 2831), true)
            
            #line 58 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create(" ", 2835), Tuple.Create<System.Object, System.Int32>(isPulledRight
            
            #line default
            #line hidden
, 2836), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                       Write(Html.ActionLink(Html.Resource("ForgottenPasword"), "ForgotPassword"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 61 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </div>                \r\n");

            
            #line 63 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 66 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                              Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 66 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                                                             Write(Html.Resource("LoginFormLogInButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                </div>\r\n                \r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRegistrationLink)
                {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"sf-registration-link\"");

WriteLiteral(">\r\n                <div>");

            
            #line 74 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                Write(Html.Resource("NotRegisteredYet"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3575), Tuple.Create("\"", 3604)
            
            #line 75 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 3582), Tuple.Create<System.Object, System.Int32>(Model.RegisterPageUrl
            
            #line default
            #line hidden
, 3582), false)
);

WriteLiteral(">");

            
            #line 75 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                            Write(Html.Resource("LoginFormRegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </div>\r\n");

            
            #line 77 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n            \r\n");

            
            #line 80 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 80 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">                \r\n                    <h3>");

            
            #line 83 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.Resource("UseAccountIn"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 85 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 85 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                     foreach (var provider in Model.ExternalProviders)
                    { 
                        var classToBeAdd = "btn btn-lg btn-block border " + @provider.Value;                 
                        
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"mb-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 89 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                       Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 91 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");

            
            #line 93 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 95 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591