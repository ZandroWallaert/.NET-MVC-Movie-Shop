#pragma checksum "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8e4253ec3ce2e4440cf825c15990c416f9c9ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Info), @"mvc.1.0.view", @"/Views/Details/Info.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\_ViewImports.cshtml"
using howest_movie_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\_ViewImports.cshtml"
using howest_movie_shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8e4253ec3ce2e4440cf825c15990c416f9c9ed", @"/Views/Details/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9b55669c6419058cc07cc0c7e45dd9a2a09c3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<howest_movie_shop.ViewModels.Movies.DetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    \r\n<section id=\"moviedetails\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc8e4253ec3ce2e4440cf825c15990c416f9c9ed4293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 155, "~/images/", 155, 9, true);
#nullable restore
#line 9 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
AddHtmlAttributeValue("", 164, Model.coverUrl, 164, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
AddHtmlAttributeValue("", 186, Model.title, 186, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
AddHtmlAttributeValue("", 207, Model.title, 207, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div>\r\n    <h2>\r\n        ");
#nullable restore
#line 12 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
   Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8e4253ec3ce2e4440cf825c15990c416f9c9ed6945", async() => {
                WriteLiteral("\r\n            <div class=\"info\">\r\n                <input type=\"hidden\" name=\"movieId\"");
                BeginWriteAttribute("value", " value=\"", 411, "\"", 433, 1);
#nullable restore
#line 17 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
WriteAttributeValue("", 419, Model.movieId, 419, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                <input type=\"submit\" \r\n                    value=\"Order\" \r\n                    name=\"Order\" \r\n                    id=\"orderButton\"/>\r\n            </div>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br/>\r\n        <p><span>Rating <strong>");
#nullable restore
#line 24 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
                           Write(Model.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span></p>\r\n        <p><span>Genre <strong>");
#nullable restore
#line 25 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
                          Write(Model.genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span></p>\r\n        <p><span>Year <strong>");
#nullable restore
#line 26 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
                         Write(Model.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span></p>\r\n        <p><span>Plot <strong>");
#nullable restore
#line 27 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
                         Write(Model.plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span></p>\r\n        <p><span>Actors: \r\n");
#nullable restore
#line 29 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
             foreach (string item in @Model.Actors) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong>");
#nullable restore
#line 30 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 31 "D:\Desktop\Howest Movie Shop\howest-movie-shop\Views\Details\Info.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span></p>\r\n    </div>\r\n</section>\r\n\r\n\r\n</main>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<howest_movie_shop.ViewModels.Movies.DetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
