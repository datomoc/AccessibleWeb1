#pragma checksum "C:\Users\datomo\AccessibleWeb\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63c2479faeb2b2561054c5153da0159b7b6fe55a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AccessibleWeb.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AccessibleWeb.Pages
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
#line 1 "C:\Users\datomo\AccessibleWeb\Pages\_ViewImports.cshtml"
using AccessibleWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c2479faeb2b2561054c5153da0159b7b6fe55a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f24d957e2bc8f1cda226f83bc28d61b70a8219", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("CustomerInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\datomo\AccessibleWeb\Pages\Index.cshtml"
  
  ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
  <h1 class=""display-4"">Welcome</h1>
  <p>We hope you like pizza. That's what we make here.</p>
</div>

<style>
  div.button {
    width: 200px;
    height: 50px;
    border-radius: 20px;
    background-color: lightgray;
    text-align: center;
    padding: 10px;
    margin: 50px;
  }
  input:optional {
  border-color: #ccc;
}
input:required {
  border-color: mediumblue;
}
</style>


<h2>Join our mailing list</h2>
<p>Sign up to hear about all our special offers!</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c2479faeb2b2561054c5153da0159b7b6fe55a4018", async() => {
                WriteLiteral(@"
  <div class=""container w-50 p-3"">
    <div class=""row"">
      <div class=""col-4"">
        <label for=""FirstName"">First Name</label>
      </div>
      <div class=""col-8"">
        <input type=""text"" id=""FirstName"" required>
      </div>
    </div>
    <div class=""row"">
      <div class=""col-4"">
        <label for=""LastName"">Last Name</label>
      </div>
      <div class=""col-8"">
        <input type=""text"" id=""LastName"" required>
      </div>
    </div>
    <div class=""row"">
      <div class=""col-4"">
        <label for=""Phone"">Phone</label>
      </div>
      <div class=""col-8"">
        <input type=""tel"" id=""Phone"">
      </div>
    </div>
    <div class=""row"">
      <div class=""col-4"">
        <label for=""Birthday"">Birthday</label>
      </div>
      <div class=""col-8"">
        <input type=""date"" id=""Birthday"">
      </div>
    </div>
    <div class=""row"">
      <div class=""col-4"">
        <label for=""E-mail"">E-mail Address</label>
      </div>
      <div class=""col-8"">");
                WriteLiteral("\r\n        <input type=\"email\" id=\"E-mail\" required>\r\n      </div>\r\n    </div>\r\n    <div class=\"text-center\">\r\n       <input class=\"btn btn-primary\" type=\"submit\">\r\n    </div>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2>All about our wonderful pizza!</h2>\r\n<p class=\"bg-light\">We make it fresh every day, sometimes up to two or three times a day!<br><br>\r\nWe love to make pizza!\r\n</p>\r\n\r\n<div class=\"text-center\">\r\n<img");
            BeginWriteAttribute("alt", " alt=\"", 2046, "\"", 2052, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""120"" src=""data:image/svg+xml;charset=UTF-8,%3csvg xmlns='http://www.w3.org/2000/svg'%3e%3cpath d='M.226 112L36.2.2c60 16 74 49 81 84z' fill='%23ea8'/%3e%3cpath d='M.197 112L31 14C84 29 96 57 103 88z' fill='%23fea' /%3e%3c/svg%3e"">
</div>

<h2>We take your privacy seriously!</h2>
<p class=""bg-light"">Unlike other pizza restaurants that share your pizza preferences, we care about your privacy.   <br><br>
View our <a href=""/Privacy"">privacy policy</a> for more information.
</p>

<h2>Delivery options</h2>
<p class=""bg-light"">There are a few ways we can get the  pizza to you:<br>
  - Postal mail<br>
  - Dog sled<br>
  - Drone (experimental!)
</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
