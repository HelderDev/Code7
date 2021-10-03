#pragma checksum "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b8338d97d9f540589e783fd9ee459e2b2367eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_LinkOfferClient), @"mvc.1.0.view", @"/Views/Client/LinkOfferClient.cshtml")]
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
#line 1 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
using WeChip.Model.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b8338d97d9f540589e783fd9ee459e2b2367eb", @"/Views/Client/LinkOfferClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908b4b9067fba7f3b996b205a1b2882e926a1c8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_LinkOfferClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LinkOfferClientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkOfferClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
  
    #region cor da badge de acordo com o tipo de status
    string badgeColor = string.Empty;
    switch (Model.StatusCode)
    {
        case "0001":
            badgeColor = $"<span class='badge badge-primary h-4'>{Model.Status}</span>";
            break;
        case "0007":
            badgeColor = $"<span class='badge badge-danger h-4'>{Model.Status}</span>";
            break;
        case "0009":
            badgeColor = $"<span class='badge badge-success h-4'>{Model.Status}</span>";
            break;
        case "0015":
            badgeColor = $"<span class='badge badge-warning h-4'>{Model.Status}</span>";
            break;
        case "0019":
            badgeColor = $"<span class='badge badge-info h-4'>{Model.Status}</span>";
            break;
        case "0021":
            badgeColor = $"<span class='badge badge-secondary h-4'>{Model.Status}</span>";
            break;
    }
    #endregion

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b8338d97d9f540589e783fd9ee459e2b2367eb5547", async() => {
                WriteLiteral(@"
        <div class=""card"">
            <div class=""card-header"">
                Dados do Cliente
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col text-center"">
                        Status: ");
#nullable restore
#line 41 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                           Write(Html.Raw(badgeColor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <label>Nome</label>\r\n                        ");
#nullable restore
#line 48 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.TextBoxFor(m => m.Client.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 49 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Client.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <label> CPF </label>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.TextBoxFor(m => m.Client.CPF, new { @class = "form-control", @maxlength = "14", @id = "cpfInput", @placeholder = "000.000.000-00", @oninput = "cpfChange(this.value)" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Client.CPF, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n\r\n                    <div class=\"col\">\r\n\r\n                        <label> Telefone </label>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.TextBoxFor(m => m.Client.Phone, new { @class = "form-control", @id = "phone", @name = "phone", @onkeypress = "mask(this, mphone);", @onblur = "mask(this, mphone);" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 63 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Client.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <label> Crédito </label>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.TextBoxFor(m => m.Client.Credit, new { @class = "form-control", @id = "currency" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 68 "C:\Users\Helder\source\repos\ProvaPratica_Code7\WeChip\Views\Client\LinkOfferClient.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Client.Credit, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <br />
       <div class=""card"">
           <div class=""card-body"">
               <div class=""row"">
                   <div class=""col"">
                       AAAA
                   </div>
               </div>
           </div>
       </div>

        <hr />
        <div class=""row"">
            <button type=""submit"" class=""btn btn-primary btn-block""> Registrar Cliente </button>
        </div>

    ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkOfferClientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591