#pragma checksum "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5ae4ba174b50984c91286924bb253c5b0b94fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario__ContatosUsuarios), @"mvc.1.0.view", @"/Views/Usuario/_ContatosUsuarios.cshtml")]
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
#line 1 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\_ViewImports.cshtml"
using Controle_Contatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\_ViewImports.cshtml"
using Controle_Contatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5ae4ba174b50984c91286924bb253c5b0b94fe", @"/Views/Usuario/_ContatosUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"575b5b9d287c7b52fbabdb81a05ab32699a70c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario__ContatosUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table display"" style=""width:100%"" id=""table-contatos-usuario"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">E-mail</th>
            <th scope=""col"">Celular</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 14 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (var contato in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line 19 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
                                   Write(contato.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <td>");
#nullable restore
#line 20 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
                       Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 21 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
                       Write(contato.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 22 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
                       Write(contato.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 24 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr class=\"odd\"><td valign=\"top\" colspan=\"4\">Nenhum contato encontrato</td></tr>\r\n");
#nullable restore
#line 29 "C:\Users\Eduardo\Desktop\ControleContatos-main\Controle Contatos\Views\Usuario\_ContatosUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContatoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
