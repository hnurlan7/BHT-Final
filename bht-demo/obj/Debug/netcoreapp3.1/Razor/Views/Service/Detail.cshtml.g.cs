#pragma checksum "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f68b9630e6217e9f2b5abfc79d20042544aaedb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Detail), @"mvc.1.0.view", @"/Views/Service/Detail.cshtml")]
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
#line 1 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\_ViewImports.cshtml"
using bht_demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\_ViewImports.cshtml"
using bht_demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\_ViewImports.cshtml"
using bht_demo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\_ViewImports.cshtml"
using bht_demo.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f68b9630e6217e9f2b5abfc79d20042544aaedb6", @"/Views/Service/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50cc8182fe5cb05bf16f34bf574a62b83ca8706", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceAndAbout>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bht"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sendmessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Main start -->\r\n<main>\r\n    <!-- Hero -->\r\n    <section class=\"hero\">\r\n        <div class=\"image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f68b9630e6217e9f2b5abfc79d20042544aaedb64914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 242, "~/uploads/page/", 242, 15, true);
#nullable restore
#line 12 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml"
AddHtmlAttributeValue("", 257, Model.HeroImgUrl, 257, 17, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"info\">\r\n            <h1 class=\"page-title\">");
#nullable restore
#line 15 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n    </section>\r\n    <!-- Hero end -->\r\n    <!-- Static Text start -->\r\n    <section class=\"static-text\">\r\n        <div class=\"container\">\r\n            <div class=\"title\">\r\n                <h1>");
#nullable restore
#line 23 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"subtitle\">\r\n                <p>");
#nullable restore
#line 26 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml"
              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </section>
    <!-- Static Text end -->
    <!-- Content -->
    <section class=""page-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""text"">
                        ");
#nullable restore
#line 37 "C:\Users\hnurl\Desktop\baku-holiday-travelv2\bht-demo\Views\Service\Detail.cshtml"
                   Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <!--/.col -->
            </div>
        </div>
    </section>

    <!-- Contact start -->
    <section class=""contact"">
        <div class=""container"">
            <div class=""row row-cols-1"">
                <h3 class=""title"">B??Z?? YAZIN</h3>
            </div>
            <div class=""contacts"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f68b9630e6217e9f2b5abfc79d20042544aaedb68582", async() => {
                WriteLiteral(@"
                    <div class=""row row-cols-md-3"">
                        <div class=""col"">
                            <label for=""firstName"">Ad??</label>
                            <input name=""firstName""
                                   placeholder=""Ad??n??z?? daxil edin""
                                   type=""text"" />
                        </div>
                        <div class=""col"">
                            <label for=""lastName"">Soyad??</label>
                            <input name=""lastName""
                                   placeholder=""Soyad??n??z?? daxil edin""
                                   type=""text"" />
                        </div>
                        <div class=""col"">
                            <label for=""email"">Ad??</label>
                            <input name=""email""
                                   placeholder=""Email ??nvan??n??z?? daxil edin""
                                   type=""text"" />
                        </div>
                    </div>
");
                WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-4"">
                            <label for=""mobileNumber"">Mobil n??mr??niz</label>
                            <input name=""mobileNumber""
                                   placeholder=""Mobil n??mr??nizi daxil edin""
                                   type=""number"" />
                        </div>
                        <div class=""col-md-8"">
                            <label for=""message"">Mesaj??n??z</label>
                            <textarea name=""message""
                                      placeholder=""Mesaj??n??z?? daxil edin""></textarea>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-2"">
                            <div class=""actions"">
                                <button class=""form-submit"" type=""submit"">
                                    m??ktubu g??nd??r
                                </button>
               ");
                WriteLiteral("             </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Contact end -->\r\n</main>\r\n<!-- Main end -->\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceAndAbout> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
