#pragma checksum "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0ea3c13a409d05cd38566fda1ac5e0852d274b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vagas_Details), @"mvc.1.0.view", @"/Views/Vagas/Details.cshtml")]
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
#line 1 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\_ViewImports.cshtml"
using Wejobr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\_ViewImports.cshtml"
using Wejobr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e0ea3c13a409d05cd38566fda1ac5e0852d274b", @"/Views/Vagas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce6b53a90b1a9d2cb8f686b2b94175c02529ff8", @"/Views/_ViewImports.cshtml")]
    public class Views_Vagas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wejobr.Models.Vaga>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/vagas.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btnFechar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e0ea3c13a409d05cd38566fda1ac5e0852d274b4690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
   ViewData["Title"] = "Ver detalhes da vaga"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""container pt-4"">
    <section class=""container-fluid"" id=""vagasSection1"">
        <h2 class=""mt-3 ml-3"">Detalhes da vaga</h2>
        <hr />
        <div class=""container d-flex flex-column justify-content-center mt-3 mb-4 p-3 border border-light shadow-sm bg-light rounded"">


            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-md-6 ml-auto"">
                        <h6>Cargo</h6>
                        <p>");
#nullable restore
#line 18 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Cargo_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>Código da vaga</h6>\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Cod_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>Salário</h6>\r\n                        <p>R$ ");
#nullable restore
#line 28 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Salario_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>Localidade</h6>\r\n                        <p>");
#nullable restore
#line 32 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Localidade_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <h6>Descrição da vaga</h6>\r\n                <p>");
#nullable restore
#line 36 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
              Write(Html.DisplayFor(model => model.Descricao_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>Nível de instrução</h6>\r\n                        <p>");
#nullable restore
#line 40 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Nivel_instrucao_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>Vaga também direcionada à PCD?</h6>\r\n                        <p>");
#nullable restore
#line 44 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Vaga_pcd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>Regime de contratação</h6>\r\n                        <p>");
#nullable restore
#line 50 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Regime_contratacao_vaga));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-6 ml-auto\">\r\n                        <h6>ID da empresa</h6>\r\n                        <p>");
#nullable restore
#line 54 "C:\Users\Danilo J (Dejota)\Documents\Recode\Projeto Squad 22\Entrega 3\Wejobr\Wejobr\Views\Vagas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Id_empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e0ea3c13a409d05cd38566fda1ac5e0852d274b10925", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wejobr.Models.Vaga> Html { get; private set; }
    }
}
#pragma warning restore 1591
