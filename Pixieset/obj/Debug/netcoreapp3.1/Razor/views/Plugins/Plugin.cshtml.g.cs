#pragma checksum "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "814729d79caa4dc38252e7f768c46607f654e14c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Plugins_Plugin), @"mvc.1.0.view", @"/views/Plugins/Plugin.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\_ViewImports.cshtml"
using Pixieset.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\_ViewImports.cshtml"
using Pixieset.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814729d79caa4dc38252e7f768c46607f654e14c", @"/views/Plugins/Plugin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b0a73d6c4011eedc1b46aaa0a929b55221db1b", @"/views/_ViewImports.cshtml")]
    #nullable restore
    public class views_Plugins_Plugin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PluginsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814729d79caa4dc38252e7f768c46607f654e14c3808", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"">
    <link rel=""stylesheet"" href=""../assets/css/Products.css"">
    <link rel=""stylesheet"" href=""../assets/css/plugins.css"">
");
#nullable restore
#line 9 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
      
    ViewData["Title"] = "Plugin";

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   <main>\r\n        <section id=\"first\">\r\n            <div class=\"title\">\r\n                <h3>");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
               Write(Model.PluginFirst.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n        </section>\r\n        <section id=\"stream\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"title\">\r\n                        <h3>");
#nullable restore
#line 24 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                       Write(Model.PluginStream.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 25 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                      Write(Model.PluginStream.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </section>
        <section id=""light"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""title col-lg-7"">
                        <h3>");
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                       Write(Model.PluginsLight.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 35 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                      Write(Model.PluginsLight.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1413, "\"", 1420, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h5>");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                           Write(Model.PluginsLight.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i");
            BeginWriteAttribute("class", " class=\"", 1481, "\"", 1513, 1);
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
WriteAttributeValue("", 1489, Model.PluginsLight.Icon, 1489, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></h5>\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1582, "\"", 1589, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">");
#nullable restore
#line 39 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                                          Write(Model.PluginsLight.Btn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"image col-lg-5\"><img");
            BeginWriteAttribute("src", " src=\"", 1712, "\"", 1760, 2);
            WriteAttributeValue("", 1718, "../assets/images/", 1718, 17, true);
#nullable restore
#line 41 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
WriteAttributeValue("", 1735, Model.PluginsLight.Image, 1735, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1761, "\"", 1767, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                </div>
            </div>
        </section>
         <section id=""get"">
        <div class=""get"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""title"">
                        <h3> ");
#nullable restore
#line 50 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                        Write(Model.Get.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                    </div>\r\n                    <div class=\"text\">\r\n                        <p>");
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                      Write(Model.Get.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                     if (User.Identity.IsAuthenticated)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814729d79caa4dc38252e7f768c46607f654e14c10501", async() => {
#nullable restore
#line 59 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                                                                     Write(Model.Get.Link);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814729d79caa4dc38252e7f768c46607f654e14c12344", async() => {
#nullable restore
#line 64 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                                                                       Write(Model.Get.Link);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Plugins\Plugin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>
    </main>
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""
    integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.min.js""
    integrity=""sha512-XtmMtDEcNz2j7ekrtHvOVR4iwwaD6o/FUJe6+Zq+HgcCsk3kj4uSQQR8weQ2QVj1o0Pk6PwYLohm206ZzNfubg==""
    crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script src=""../assets/javascript/products.js""></script>




");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PluginsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591