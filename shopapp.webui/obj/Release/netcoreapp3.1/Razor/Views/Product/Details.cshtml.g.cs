#pragma checksum "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Product\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d936f4ba78ec7a4bcc91ba6ef5985edd718a456c5e119c24f6d4ddccbbf4ef9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d936f4ba78ec7a4bcc91ba6ef5985edd718a456c5e119c24f6d4ddccbbf4ef9f", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fbfbe6d65edb8462deb7247d34b3d2c339446211ece7e7b9b6b398850cdb6dd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 5 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Product\Details.cshtml"
     await Component.InvokeAsync("Categories")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-body\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d936f4ba78ec7a4bcc91ba6ef5985edd718a456c5e119c24f6d4ddccbbf4ef9f5456", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 249, "~/img/", 249, 6, true);
            AddHtmlAttributeValue("", 255, 
#nullable restore
#line 12 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Product\Details.cshtml"
                                 Model.ImageUrl

#line default
#line hidden
#nullable disable
            , 255, 15, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                \r\n                    <h5 class=\"card-title\">");
            Write(
#nullable restore
#line 16 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Product\Details.cshtml"
                                            Model.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
            Write(
#nullable restore
#line 17 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Product\Details.cshtml"
                                          Model.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">\r\n                        <small class=\"text-muted\">3 days ago</small>\r\n                    </p>\r\n            \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
