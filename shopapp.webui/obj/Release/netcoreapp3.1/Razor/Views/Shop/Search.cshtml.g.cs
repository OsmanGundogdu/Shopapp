#pragma checksum "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Shop\Search.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54e3ea3e0611c1b3a325dc00813bb096de06b951aa26eda23759fe18f6bb5cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Search), @"mvc.1.0.view", @"/Views/Shop/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"54e3ea3e0611c1b3a325dc00813bb096de06b951aa26eda23759fe18f6bb5cc5", @"/Views/Shop/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fbfbe6d65edb8462deb7247d34b3d2c339446211ece7e7b9b6b398850cdb6dd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            Write(
#nullable restore
#line 5 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Shop\Search.cshtml"
         await Component.InvokeAsync("Categories")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 9 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Shop\Search.cshtml"
             foreach (var product in Model.Products)
            {    

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
            Write(
#nullable restore
#line 12 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Shop\Search.cshtml"
                     await Html.PartialAsync("_product", product)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 14 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Shop\Search.cshtml"
            }   

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
