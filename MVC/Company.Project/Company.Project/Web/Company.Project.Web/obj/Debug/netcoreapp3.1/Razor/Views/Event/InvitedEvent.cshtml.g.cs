#pragma checksum "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4c0fb8f7bfccd4baee37bdd2751c4705168009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_InvitedEvent), @"mvc.1.0.view", @"/Views/Event/InvitedEvent.cshtml")]
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
#line 1 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\_ViewImports.cshtml"
using Company.Project.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\_ViewImports.cshtml"
using Company.Project.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4c0fb8f7bfccd4baee37bdd2751c4705168009", @"/Views/Event/InvitedEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02771b3bf5c583f55fe47d163deb1c41c26a926", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_InvitedEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Company.Project.Web.Models.BookReadingEventModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
  
    ViewData["Title"] = "Invited Event";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center"">Welcome to your invited events.  </h2>
<br />
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-6"" style=""height:70vh; overflow-y: scroll;"">
            <table class="" table table-striped"" border=""1"">
                <tr>
                    <th colspan=""5"">
                        <button class=""alert"" style=""background-color:teal;color:white;width:100%"">
                            <b>Future Events</b>
                        </button>
                    </th>
                </tr>
                <tr style="" background-color:cadetblue;color:white;width:100%"">
                    <th>
                        ");
#nullable restore
#line 21 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 36 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                 foreach (var element in Model)
                {
                    var dateOfEvent = element.Date.ToString("yyyy-MM-dd");
                    var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    DateTime event_Date = Convert.ToDateTime(dateOfEvent);
                    DateTime current_Date = Convert.ToDateTime(currentDate);
                    if (event_Date >= current_Date)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 46 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                           Write(Html.DisplayFor(modelItem => element.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4c0fb8f7bfccd4baee37bdd2751c47051680098827", async() => {
                WriteLiteral(" ");
#nullable restore
#line 49 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                                                                                                                                                   Write(element.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                                                                                WriteLiteral(element.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                           Write(Html.DisplayFor(modelItem => element.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                           Write(Html.DisplayFor(modelItem => element.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 63 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </div>
        <div class=""col-6"" style=""height:70vh; overflow-y: scroll;"">
            <table class="" table table-striped"" border=""1"">
                <tr>
                    <th colspan=""4"">
                        <button class=""alert"" style=""background-color:teal;color:white;width:100%"">
                            <b>Previous Events</b>
                        </button>
                    </th>
                </tr>
                <tr style="" background-color:cadetblue;color:white;width:100%"">
                    <th>
                        ");
#nullable restore
#line 78 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 81 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 84 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 87 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                   Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 90 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                 foreach (var element in Model)
                {
                    var dateOfEvent = element.Date.ToString("yyyy-MM-dd");
                    var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    DateTime event_Date = Convert.ToDateTime(dateOfEvent);
                    DateTime current_Date = Convert.ToDateTime(currentDate);
                    if (event_Date < current_Date)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 100 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                           Write(Html.DisplayFor(modelItem => element.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4c0fb8f7bfccd4baee37bdd2751c470516800916454", async() => {
                WriteLiteral(" ");
#nullable restore
#line 103 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                                                                                                                                                   Write(element.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                                                                                WriteLiteral(element.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 106 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                           Write(Html.DisplayFor(modelItem => element.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 109 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                           Write(Html.DisplayFor(modelItem => element.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 112 "D:\avinash-srivastav\MVC Assignment\MVC\Company.Project\Company.Project\Web\Company.Project.Web\Views\Event\InvitedEvent.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff4c0fb8f7bfccd4baee37bdd2751c470516800920840", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Company.Project.Web.Models.BookReadingEventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
