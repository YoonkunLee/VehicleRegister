#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2e9e9968beb2bf532529a5ab7296a376bd95bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistedVehicle_CreateRegistedVehical), @"mvc.1.0.view", @"/Views/RegistedVehicle/CreateRegistedVehical.cshtml")]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\_ViewImports.cshtml"
using VehicleRegister.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\_ViewImports.cshtml"
using VehicleRegister.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2e9e9968beb2bf532529a5ab7296a376bd95bce", @"/Views/RegistedVehicle/CreateRegistedVehical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e18ea022ea74717d0ff7aea4c8e512d2c8ab29a", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistedVehicle_CreateRegistedVehical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleRegister.ViewModel.RegisteredVehicleView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
  
    ViewData["Title"] = "CreateRegistedVehical";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateRegistedVehical</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
 using (Html.BeginForm("Create", "RegistedVehicle", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.LabelFor(m => m.OwnerName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.TextBoxFor(m => m.OwnerName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.LabelFor(m => m.Manufacturer));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.TextBoxFor(m => m.Manufacturer));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.LabelFor(m => m.Year));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.TextBoxFor(m => m.Year, "{ yyyy }"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.LabelFor(m => m.Weight));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
Write(Html.TextBoxFor(m => m.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 20 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\RegistedVehicle\CreateRegistedVehical.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleRegister.ViewModel.RegisteredVehicleView> Html { get; private set; }
    }
}
#pragma warning restore 1591
