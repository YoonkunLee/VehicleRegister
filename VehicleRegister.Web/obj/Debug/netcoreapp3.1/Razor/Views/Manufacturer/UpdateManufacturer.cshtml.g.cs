#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcedfbc11df95ee48e39187b0b7d6336529e0573"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturer_UpdateManufacturer), @"mvc.1.0.view", @"/Views/Manufacturer/UpdateManufacturer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcedfbc11df95ee48e39187b0b7d6336529e0573", @"/Views/Manufacturer/UpdateManufacturer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e18ea022ea74717d0ff7aea4c8e512d2c8ab29a", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturer_UpdateManufacturer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleRegister.ViewModel.ManufacturerView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml"
  
    ViewData["Title"] = "UpdateManufacturer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"titleMargin\">Update Manufacturer</h3>\r\n");
#nullable restore
#line 7 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml"
 using(Html.BeginForm("UpdateManufacturer", "Manufacturer", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml"
Write(Html.LabelFor(m => m.name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml"
Write(Html.TextBoxFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input class=\"waves-effect waves-light btn-large blue submitButton\" type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\UpdateManufacturer.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleRegister.ViewModel.ManufacturerView> Html { get; private set; }
    }
}
#pragma warning restore 1591
