#pragma checksum "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f8244c1b33a1be377ee5e5021779103b94a840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instrument_Delete), @"mvc.1.0.view", @"/Views/Instrument/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f8244c1b33a1be377ee5e5021779103b94a840", @"/Views/Instrument/Delete.cshtml")]
    public class Views_Instrument_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InstruBank.Models.Instrument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
 using (Html.BeginForm("Delete", "Instrument"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 8 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 9 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 10 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 11 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 12 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n    <p>\r\n        <input type=\"submit\" value=\"Delete\" />\r\n\r\n    </p>\r\n");
#nullable restore
#line 28 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
Write(Html.ActionLink("Volver a Página de Inicio", "Index"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\ferlu\Desktop\Portfolio\Project_1\InstruBank\Views\Instrument\Delete.cshtml"
                                                          
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstruBank.Models.Instrument> Html { get; private set; }
    }
}
#pragma warning restore 1591
