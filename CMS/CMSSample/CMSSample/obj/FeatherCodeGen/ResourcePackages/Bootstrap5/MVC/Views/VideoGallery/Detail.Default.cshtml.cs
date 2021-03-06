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

namespace CMSSample.ResourcePackages.Bootstrap5.MVC.Views.VideoGallery
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
    
    #line 3 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/VideoGallery/Detail.Default.cshtml")]
    public partial class Detail_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery.VideoDetailsViewModel>
    {

#line 77 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
public System.Web.WebPages.HelperResult GetCaretDirection(string arrow)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 78 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
 
    bool isRtl = ((Html.RenderDirAttribute().ToString() == "dir=\"rtl\"")?true:false);

    if (arrow == "next" && !isRtl || arrow == "prev" && isRtl)
    {
        

#line default
#line hidden

#line 83 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-right"));


#line default
#line hidden

#line 83 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                         ;
    }
    else
    {
        

#line default
#line hidden

#line 87 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-left"));


#line default
#line hidden

#line 87 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                        ;
    }


#line default
#line hidden
});

#line 89 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
}
#line default
#line hidden

        public Detail_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
  
    var tmbWidth = string.Empty;
    var tmbHeight = string.Empty;

    if (Model.Item.Fields.Width != null && Model.Item.Fields.Width != 0)
    {

        tmbWidth = string.Format("width={0}", Model.Item.Fields.Width);
    }

    if (Model.Item.Fields.Height != null && Model.Item.Fields.Height != 0)
    {

        tmbHeight = string.Format("height={0}", Model.Item.Fields.Height);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 632), Tuple.Create("\"", 655)
            
            #line 24 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 640), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 640), false)
);

WriteLiteral(" ");

            
            #line 24 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <figure");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 776), Tuple.Create("\"", 823)
            
            #line 25 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 794), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" VideoTitle")
            
            #line default
            #line hidden
, 794), false)
);

WriteLiteral(">\r\n        <figcaption");

WriteLiteral(" class=\"h2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 857), Tuple.Create("\"", 891)
            
            #line 26 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 862), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" VideoTitle")
            
            #line default
            #line hidden
, 862), false)
);

WriteLiteral(" ");

            
            #line 26 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                             Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 26 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                      Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</figcaption>\r\n        <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                     Write(Html.Resource("VideoTakenOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
       Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
       Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
       Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <p ");

            
            #line 33 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
      Write(Html.InlineEditingFieldAttributes("Description", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(" id=\'");

            
            #line 33 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                        Write(Html.UniqueId("VideoInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'>");

            
            #line 33 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                     Write(Html.HtmlSanitize((string)Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <div");

WriteLiteral(" class=\"d-flex justify-content-center bg-light\"");

WriteLiteral(">\r\n            <video");

WriteAttribute("src", Tuple.Create(" src=\"", 1558), Tuple.Create("\"", 1589)
            
            #line 35 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1564), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 1564), false)
);

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteLiteral(" controls=\"controls\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1632), Tuple.Create("\'", 1678)
            
            #line 35 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                              , Tuple.Create(Tuple.Create("", 1650), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoTitle")
            
            #line default
            #line hidden
, 1650), false)
);

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 1679), Tuple.Create("\'", 1725)
            
            #line 35 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                              , Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoInfo")
            
            #line default
            #line hidden
, 1698), false)
);

WriteLiteral(" ");

            
            #line 35 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                                                                                      Write(tmbWidth);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 35 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                                                                                                Write(tmbHeight);

            
            #line default
            #line hidden
WriteLiteral("></video>\r\n        </div>\r\n\r\n    </figure>\r\n");

            
            #line 39 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 39 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1865), Tuple.Create("\"", 1914)
            
            #line 41 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create<System.Object, System.Int32>(Html.Resource(" PreviousNextVideo")
            
            #line default
            #line hidden
, 1878), false)
);

WriteLiteral(" class=\"d-flex justify-content-between mb-3\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
              
                var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
                var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
            
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 47 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.PreviousItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2296), Tuple.Create("\"", 2345)
            
            #line 49 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2309), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToPreviousVideo")
            
            #line default
            #line hidden
, 2309), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2346), Tuple.Create("\"", 2495)
            
            #line 49 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2353), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 2353), false)
);

WriteLiteral(">\r\n                    <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 2604), Tuple.Create("\"", 2703)
, Tuple.Create(Tuple.Create("", 2617), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 2617), false)
            
            #line 51 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                     , Tuple.Create(Tuple.Create("", 2677), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("prev")
            
            #line default
            #line hidden
, 2677), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n");

WriteLiteral("                    ");

            
            #line 53 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
               Write(Html.Resource("PreviousVideo"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 55 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 57 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 57 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.PreviousItem != null || Model.NextItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span>");

            
            #line 59 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                 Write(Html.HtmlSanitize((string)string.Format(Html.Resource("IndexOfTotal"), ViewBag.ItemIndex, Model.TotalItemsCount)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 60 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 62 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 62 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.NextItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3176), Tuple.Create("\"", 3221)
            
            #line 64 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3189), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToNextVideo")
            
            #line default
            #line hidden
, 3189), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3222), Tuple.Create("\"", 3363)
            
            #line 64 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3229), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 3229), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 65 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
               Write(Html.Resource("NextVideo"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 3521), Tuple.Create("\"", 3620)
, Tuple.Create(Tuple.Create("", 3534), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 3534), false)
            
            #line 67 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                     , Tuple.Create(Tuple.Create("", 3594), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("next")
            
            #line default
            #line hidden
, 3594), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n                </a>\r\n");

            
            #line 70 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </nav>\r\n");

            
            #line 72 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"

        
            
            #line default
            #line hidden
            
            #line 73 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
   Write(Html.ActionLink(Html.Resource("BackToAllVideos"), "Index"));

            
            #line default
            #line hidden
            
            #line 73 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                   
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
