#pragma checksum "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e57ea52db4d98ab7e58b609ea02305578dd315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_OfferClient), @"mvc.1.0.view", @"/Views/Client/OfferClient.cshtml")]
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
#line 1 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\_ViewImports.cshtml"
using WeChip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\_ViewImports.cshtml"
using WeChip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
using WeChip.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
using WeChip.DomainModel.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e57ea52db4d98ab7e58b609ea02305578dd315", @"/Views/Client/OfferClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908b4b9067fba7f3b996b205a1b2882e926a1c8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_OfferClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OfferViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfferClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
     if (!string.IsNullOrEmpty(ViewBag.FlowMessage))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                    <strong>");
#nullable restore
#line 15 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                       Write(ViewBag.FlowMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
            </div>
        </div>
");
#nullable restore
#line 22 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0e57ea52db4d98ab7e58b609ea02305578dd3155772", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col"">
                <div class=""table-responsive"">
                    <table class=""table table-hover table-bordered"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>
                                    Nome
                                </th>
                                <th>
                                    CPF
                                </th>
                                <th>
                                    Crédito
                                </th>
                                <th>
                                    Status
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 46 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                             if (Model.Clients == null || !Model.Clients.Any())
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <tr>
                                    <td colspan=""4"" class=""text-center"">
                                        Não há clientes para exibir.
                                    </td>
                                </tr>
");
#nullable restore
#line 53 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                 foreach (var item in Model.Clients)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 60 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 63 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                       Write(item.CPF);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 66 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                       Write(item.Credit);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"text-center\">\r\n");
#nullable restore
#line 69 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                             switch (item.Status.StatusCode)
                                            {
                                                case StatusEnum.FreeName:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <h4 class=\'badge badge-primary \'>");
#nullable restore
#line 72 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                 Write((int)item.Status.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 72 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                                                 Write(item.Status.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 73 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                    break;
                                                case StatusEnum.DoNotWishToBeContacted:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <h4 class=\'badge badge-danger \'>");
#nullable restore
#line 75 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                Write((int)item.Status.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 75 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                                                Write(item.Status.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 76 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                    break;
                                                case StatusEnum.ClientAcceptedTheOffer:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <h4 class=\'badge badge-success \'>");
#nullable restore
#line 78 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                 Write((int)item.Status.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 78 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                                                 Write(item.Status.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 79 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                    break;
                                                case StatusEnum.CallEnded:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <h4 class=\'badge badge-warning \'>");
#nullable restore
#line 81 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                 Write((int)item.Status.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 81 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                                                 Write(item.Status.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 82 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                    break;
                                                case StatusEnum.Traveled:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <h4 class=\'badge badge-info \'>");
#nullable restore
#line 84 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                              Write((int)item.Status.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 84 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                                              Write(item.Status.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 85 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                    break;
                                                case StatusEnum.Deceased:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <h4 class=\'badge badge-secondary \'>");
#nullable restore
#line 87 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                   Write((int)item.Status.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 87 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                                                                                   Write(item.Status.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 88 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                                    break;
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td><a class=\"btn btn-success btn-block\"");
                BeginWriteAttribute("href", " href=\"", 4903, "\"", 4979, 1);
#nullable restore
#line 93 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
WriteAttributeValue("", 4910, Url.Action("LinkOfferClient", "Client", new {clientCPF = item.CPF }), 4910, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Ofertar</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\OfferClient.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    $(document).ready(function () {
        $('.table').DataTable({
            ""language"": {
                ""lengthMenu"": ""Exibindo _MENU_ registros por página"",
                ""zeroRecords"": ""Nenhum registro encontrado"",
                ""info"": ""Exibindo a página _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Sem registros disponíveis"",
                ""infoFiltered"": ""(Filtrado de _MAX_ registros totais)"",
                ""sSearch"": ""Procurar: "",
                ""paginate"": {
                    ""previous"": ""Página anterior "",
                    ""next"": "" Próxima página""
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfferViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
