#pragma checksum "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bba7574e5eb5faf4c17016d37d6b166cc951af3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\_ViewImports.cshtml"
using HostelApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\_ViewImports.cshtml"
using HostelApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bba7574e5eb5faf4c17016d37d6b166cc951af3", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e34cb83ea3ec2e2116bd92a08035c68a4429f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HostelApplication.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/Create/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary lg-c-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Student Page";
    Layout = "~/Views/Shared/LayoutNew.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<div class=\"col-6\">\r\n    <h2 class=\"text-info\" style=\"font-size:35px\">Student List</h2>\r\n</div>\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bba7574e5eb5faf4c17016d37d6b166cc951af36513", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>Create New Student");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"form-border\" style=\"margin-top:40px;\">\r\n");
#nullable restore
#line 23 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped table-hover\" id=\"jayb1\">\r\n            <thead style=\"background-color: azure; font-size: 35px;\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MatricNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 41 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OtherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Faculty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 47 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 50 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 53 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 56 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 59 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SessionofAdmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    \r\n                    <th>\r\n                        ");
#nullable restore
#line 63 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 66 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody style=\"font-size: 35px;\">\r\n");
#nullable restore
#line 73 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                 foreach (var item in Model)
                {
                    var Id = item.StudentId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                         <td>\r\n                            ");
#nullable restore
#line 81 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MatricNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 90 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Faculty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 93 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 96 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 99 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 102 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 105 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 108 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SessionofAdmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        \r\n                        <td>\r\n                            ");
#nullable restore
#line 112 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 115 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Updated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                        <td class=\"text-center\">\r\n                            <div class=\"w-75 btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bba7574e5eb5faf4c17016d37d6b166cc951af318542", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>&nbspEdit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                                                              WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bba7574e5eb5faf4c17016d37d6b166cc951af321086", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i>&nbspDelete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                                                              WriteLiteral(item.StudentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            </div>\r\n\r\n                        </td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 131 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 134 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <center> <p><b>No items is created</b></p></center>\r\n");
#nullable restore
#line 138 "C:\Users\USER\source\repos\HostelApplication\HostelApplication\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script>
    $(document).ready(function () {
        $(""#jayb1"").DataTable({
            dom: 'Bfrtip',
            buttons: [
                'excel', 'pdf', 'print'
            ]
        });

        $(""#dialog-form"").dialog({
            modal: true
        });

    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HostelApplication.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591