#pragma checksum "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "efc4bf0eab48fa3f07baac114b55cdff327c2a07234342bf68d00c6ab34214f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"efc4bf0eab48fa3f07baac114b55cdff327c2a07234342bf68d00c6ab34214f5", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fbfbe6d65edb8462deb7247d34b3d2c339446211ece7e7b9b6b398850cdb6dd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/user/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            WriteLiteral("  \r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js""></script>

    <script>
        $(document).ready( function () {
            $('#myTable').DataTable();
        });
    </script>

");
            }
            );
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">User List</h1>
        <hr>
        <a class=""btn btn-primary btn-sm"" href=""/admin/user/create"">Create User</a>
        <hr>
        <table data-page-length='3' id=""myTable"" class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td>FirstName</td>
                    <td>LastName</td>
                    <td>UserName</td>
                    <td>Email</td>
                    <td>EmailConfirmed</td>
                    <td style=""width: 160px;""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                 if(Model.Count()>0)
                {
                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 42 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <tr>\r\n                            <td>");
            Write(
#nullable restore
#line 45 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                 item.FirstName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 46 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                 item.LastName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>                              \r\n                            <td>");
            Write(
#nullable restore
#line 47 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                 item.UserName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>                              \r\n                            <td>");
            Write(
#nullable restore
#line 48 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                 item.Email

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>                              \r\n                            <td>");
            Write(
#nullable restore
#line 49 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                 item.EmailConfirmed

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>                              \r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1785, 2);
            WriteAttributeValue("", 1765, "/admin/user/", 1765, 12, true);
            WriteAttributeValue("", 1777, 
#nullable restore
#line 51 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                                      item.Id

#line default
#line hidden
#nullable disable
            , 1777, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                                \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc4bf0eab48fa3f07baac114b55cdff327c2a07234342bf68d00c6ab34214f510467", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 2044, "\"", 2060, 1);
                WriteAttributeValue("", 2052, 
#nullable restore
#line 54 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                                                                               item.Id

#line default
#line hidden
#nullable disable
                , 2052, 8, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 59 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                     
                }else{

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Users</h3>\r\n                    </div>\r\n");
#nullable restore
#line 64 "C:\Users\osman1\Desktop\Programlama\programlama projelerim\vscode projelerim (udemy)\shopapp (3) - API yok\shopapp.webui\Views\Admin\UserList.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
