#pragma checksum "C:\Users\wilbe\firstApplication\Views\Home\Personal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff51989596b04eb09937c711221444a600aef3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Personal), @"mvc.1.0.view", @"/Views/Home/Personal.cshtml")]
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
#line 1 "C:\Users\wilbe\firstApplication\Views\_ViewImports.cshtml"
using firstApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wilbe\firstApplication\Views\_ViewImports.cshtml"
using firstApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff51989596b04eb09937c711221444a600aef3d", @"/Views/Home/Personal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df49d661beca9a22efd546ea84e0e996c7730177", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Personal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\wilbe\firstApplication\Views\Home\Personal.cshtml"
  
    ViewData["Title"] = "Personal";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Wilber Jose Jimenez Ramirez</h1>

<button type=""button"" class=""btn btn-primary"">
  Notifications <span class=""badge bg-secondary"">4</span>
</button>

<button type=""button"" class=""btn btn-primary position-relative"">
  Inbox
  <span class=""position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger"">
    99+
    <span class=""visually-hidden"">unread messages</span>
  </span>
</button>




<div class=""card"" style=""width: 18rem;"">
  <img src=""..."" class=""card-img-top"" alt=""..."">
  <div class=""card-body"">
    <h5 class=""card-title"">Sobre el usuario</h5>
    <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
  </div>
</div>


<div class=""accordion"" id=""accordionExample"">
  <div class=""accordion-item"">
    <h2 class=""accordion-header"" id=""headingOne"">
      <button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs");
            WriteLiteral(@"-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
        Educacion
      </button>
    </h2>
    <div id=""collapseOne"" class=""accordion-collapse collapse show"" aria-labelledby=""headingOne"" data-bs-parent=""#accordionExample"">
      <div class=""accordion-body"">
        <strong>This is the first item's accordion body.</strong> It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class=""accordion-item"">
    <h2 class=""accordion-header"" id=""headingTwo"">
      <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapse");
            WriteLiteral(@"Two"" aria-expanded=""false"" aria-controls=""collapseTwo"">
        Experiencia 
      </button>
    </h2>
    <div id=""collapseTwo"" class=""accordion-collapse collapse"" aria-labelledby=""headingTwo"" data-bs-parent=""#accordionExample"">
      <div class=""accordion-body"">
        <strong>This is the second item's accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
  <div class=""accordion-item"">
    <h2 class=""accordion-header"" id=""headingThree"">
      <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-exp");
            WriteLiteral(@"anded=""false"" aria-controls=""collapseThree"">
        Horas 
      </button>
    </h2>
    <div id=""collapseThree"" class=""accordion-collapse collapse"" aria-labelledby=""headingThree"" data-bs-parent=""#accordionExample"">
      <div class=""accordion-body"">
        <strong>This is the third item's accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.
      </div>
    </div>
  </div>
</div> 
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
