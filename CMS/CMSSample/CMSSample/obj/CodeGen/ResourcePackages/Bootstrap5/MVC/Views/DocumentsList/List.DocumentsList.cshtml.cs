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

namespace CMSSample.ResourcePackages.Bootstrap5.MVC.Views.DocumentsList
{
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/DocumentsList/List.DocumentsList.cshtml")]
    public partial class List_DocumentsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {

#line 48 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
public System.Web.WebPages.HelperResult GetFileExtensionCssClass(String extension)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
 

    if (extension == "xlsx")
    {
        

#line default
#line hidden

#line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-green"));


#line default
#line hidden

#line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                      ;
    }
    else if (extension == "doc" || extension == "docx")
    {
        

#line default
#line hidden

#line 57 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-blue"));


#line default
#line hidden

#line 57 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                     ;
    }
	else if (extension == "ppt" || extension == "pptx")
    {
        

#line default
#line hidden

#line 61 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-orange"));


#line default
#line hidden

#line 61 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                       ;
    }
	else if (extension == "pdf")
    {
        

#line default
#line hidden

#line 65 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-red"));


#line default
#line hidden

#line 65 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                    ;
    }
	else if (extension == "zip")
    {
        

#line default
#line hidden

#line 69 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-purple"));


#line default
#line hidden

#line 69 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                       ;
    }
	else
	{
        

#line default
#line hidden

#line 73 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-gray"));


#line default
#line hidden

#line 73 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                     ;
	}


#line default
#line hidden
});

#line 75 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
}
#line default
#line hidden

        public List_DocumentsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 230), Tuple.Create("\"", 267)
, Tuple.Create(Tuple.Create("", 238), Tuple.Create("list-unstyled", 238), true)
            
            #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create(" ", 251), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 252), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
	
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
     foreach (var item in Model.Items)
	{

            
            #line default
            #line hidden
WriteLiteral("\t<li");

WriteLiteral(" class=\"d-flex gap-3 align-items-center mb-3\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"flex-shrink-0 pt-1\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n\t\t\t<span");

WriteLiteral(" class=\"fa-layers fa-3x\"");

WriteLiteral(">\r\n\t\t\t\t<svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(">\r\n\t\t\t\t\t<use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 507), Tuple.Create("\"", 584)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#file")
, 520), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n\t\t\t\t</svg>\r\n\t\t\t\t<span");

WriteAttribute("class", Tuple.Create(" class=\"", 636), Tuple.Create("\"", 844)
, Tuple.Create(Tuple.Create("", 644), Tuple.Create("fa-layers-text", 644), true)
, Tuple.Create(Tuple.Create(" ", 658), Tuple.Create("fa-layers-bottom-right", 659), true)
, Tuple.Create(Tuple.Create(" ", 681), Tuple.Create("text-uppercase", 682), true)
, Tuple.Create(Tuple.Create(" ", 696), Tuple.Create("ps-2", 697), true)
, Tuple.Create(Tuple.Create(" ", 701), Tuple.Create("pe-2", 702), true)
, Tuple.Create(Tuple.Create(" ", 706), Tuple.Create("mb-2", 707), true)
, Tuple.Create(Tuple.Create(" ", 711), Tuple.Create("text-white", 712), true)
            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                            , Tuple.Create(Tuple.Create(" ", 722), Tuple.Create<System.Object, System.Int32>(GetFileExtensionCssClass(((DocumentItemViewModel)item).Extension)
            
            #line default
            #line hidden
, 723), false)
, Tuple.Create(Tuple.Create(" ", 789), Tuple.Create("sf-icon-txt-", 790), true)
            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                                             , Tuple.Create(Tuple.Create("", 802), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 802), false)
);

WriteLiteral(">");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                                                                                                                                                                   Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t</span>\r\n\t\t</div>\r\n\t\t<div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(">\r\n\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 966), Tuple.Create("\"", 1080)
            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 973), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
           Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</a>\r\n\t\t\t<span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1150), Tuple.Create("\"", 1195)
            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 1163), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileExtension")
            
            #line default
            #line hidden
, 1163), false)
);

WriteLiteral(">(");

            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                      Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n\r\n\t\t\t<div");

WriteLiteral(" class=\"small\"");

WriteLiteral(">\r\n\t\t\t\t<a");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1301), Tuple.Create("\"", 1329)
            
            #line 27 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 1308), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1308), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                              Write(Html.Resource("Download"));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                                                                      Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1462), Tuple.Create("\"", 1502)
            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileSize")
            
            #line default
            #line hidden
, 1475), false)
);

WriteLiteral(">(");

            
            #line 28 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                               Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</li>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("\r\n</ul>\r\n\r\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
 if (Model.ShowPager)
{
		
            
            #line default
            #line hidden
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
			 {
					 currentPage = Model.CurrentPage,
					 totalPagesCount = Model.TotalPagesCount.Value,
					 redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
			 }));

            
            #line default
            #line hidden
            
            #line 43 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
               
}



            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Bootstrap5\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                       

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591