#pragma checksum "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1daa25ef0bac6c69f702d5ea718a846b5f6619d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Detail), @"mvc.1.0.view", @"/Views/Portfolio/Detail.cshtml")]
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
#line 1 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\_ViewImports.cshtml"
using Eterna.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\_ViewImports.cshtml"
using Eterna.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1daa25ef0bac6c69f702d5ea718a846b5f6619d", @"/Views/Portfolio/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93475f84d8f33be9057fe54f0bc6f46bcfc8e379", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
      <div class=""container"">

        <ol>
          <li><a href=""index.html"">Home</a></li>
          <li>Portfolio Details</li>
        </ol>
        <h2>Portfolio Details</h2>

      </div>
    </section><!-- End Breadcrumbs -->

    <!-- ======= Portfolio Details Section ======= -->
    <section id=""portfolio-details"" class=""portfolio-details"">
      <div class=""container"">

        <div class=""row gy-4"">

          <div class=""col-lg-8"">
            <div class=""portfolio-details-slider swiper"">
              <div class=""swiper-wrapper align-items-center"">

");
#nullable restore
#line 31 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                foreach (PortfolioImage image in Model.PortfolioImages)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"swiper-slide\">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1daa25ef0bac6c69f702d5ea718a846b5f6619d4753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 930, "~/assets/img/portfolio/", 930, 23, true);
#nullable restore
#line 34 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
AddHtmlAttributeValue("", 953, image.Image, 953, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\n");
#nullable restore
#line 36 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                  
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                

              </div>
              <div class=""swiper-pagination""></div>
            </div>
          </div>

          <div class=""col-lg-4"">
            <div class=""portfolio-info"">
              <h3>Project information</h3>
              <ul>
                <li><strong>Category</strong>:");
#nullable restore
#line 50 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                                               foreach (Category category in Model.Categories)
                                           {
                                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                                          Write(category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                                                             
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><strong>Client</strong>: ");
#nullable restore
#line 54 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                                        Write(Model.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><strong>Project date</strong>: ");
#nullable restore
#line 55 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                                              Write(Model.Date.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><strong>Project URL</strong>: <a href=\"#\">");
#nullable restore
#line 56 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
                                                         Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n              </ul>\r\n            </div>\r\n            <div class=\"portfolio-description\">\r\n              <h2>This is an example of portfolio detail</h2>\r\n              <p>\r\n                  ");
#nullable restore
#line 62 "C:\Users\Crokie\Desktop\CodeAcademy\Task2\Eterna\Eterna\Views\Portfolio\Detail.cshtml"
             Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </p>\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n\r\n      </div>\r\n    </section><!-- End Portfolio Details Section -->\r\n\r\n  </main><!-- End #main -->\r\n\r\n  <!-- ======= Footer ======= -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
