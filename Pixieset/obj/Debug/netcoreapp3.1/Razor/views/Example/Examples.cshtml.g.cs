#pragma checksum "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d7b44a5291607b1497a6eba8e970fb82f430f19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Example_Examples), @"mvc.1.0.view", @"/views/Example/Examples.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7b44a5291607b1497a6eba8e970fb82f430f19", @"/views/Example/Examples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b0a73d6c4011eedc1b46aaa0a929b55221db1b", @"/views/_ViewImports.cshtml")]
    #nullable restore
    public class views_Example_Examples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExampleVM>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7b44a5291607b1497a6eba8e970fb82f430f193077", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"">
    <!-- Font Awesome -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" rel=""stylesheet"" />
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"" rel=""stylesheet"" />
    <!-- MDB -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.3.0/mdb.min.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.min.css"">
    <link rel=""stylesheet""
          href=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.theme.default.min.css"">
    <link href=""https://unpkg.com/aos@2.3.1/dist/aos.css"" rel=""stylesheet"">
    <link hre");
                WriteLiteral(@"f=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.css""
          integrity=""sha512-wR4oNhLBHf7smjy0K4oqzdWumd+r5/+6QO/vDda76MW5iug4PT7v86FoEkySIJft3XA0Ae6axhIvHrqwm793Nw==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick-theme.css""
          integrity=""sha512-6lLUdeQ5uheMFbWm3CP271l14RsX1xtx+J5x2yeIDkkiBpeVTNhTqijME7GgRKKi6hCqovwCoBTlRBEC20M8Mg==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""../assets/css/Products.css"">
    <link rel=""stylesheet"" href=""../assets/cs");
                WriteLiteral("s/example.css\">\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
  
    ViewData["Title"] = "Examples";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main>\r\n    <section id=\"first\">\r\n        <div class=\"text-center\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"title\">");
#nullable restore
#line 38 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                  Write(Model.ExampleFirst.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                   Write(Model.ExampleFirst.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                </div>

            </div>
        </div>

    </section>
    <!--Picture-->
    <section id=""picture"">

        <div class=""container"">
            <div class=""row"">
                <div id=""tab-menu"">
                    <ul class=""menu"">
");
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                         foreach (ExampleMenu menu in @Model.ExampleMenus)
                        {
                            i++;
                            var active = i == 1 ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li data-id=\"");
#nullable restore
#line 64 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                    Write(menu.DataId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 3099, "\"", 3114, 1);
#nullable restore
#line 64 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 3107, active, 3107, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"image\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 3211, "\"", 3245, 2);
            WriteAttributeValue("", 3217, "../assets/images/", 3217, 17, true);
#nullable restore
#line 66 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 3234, menu.Image, 3234, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                     alt=\"", 3246, "\"", 3290, 0);
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 67 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                             Write(menu.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                    <div class=\"body\">\r\n                        <div data-id=\"1\" class=\"item\">\r\n");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                             foreach (ExamplesRow exr in @Model.ExampleRows)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"image col-lg-4 col-sm-12\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3827, "\"", 3860, 2);
            WriteAttributeValue("", 3833, "../assets/images/", 3833, 17, true);
#nullable restore
#line 80 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 3850, exr.Image, 3850, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 3861, "\"", 3909, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 83 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                       Write(exr.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p><small>");
#nullable restore
#line 84 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                              Write(exr.Small1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n\r\n                                    <div class=\"image col-lg-4 col-sm-12\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4253, "\"", 4287, 2);
            WriteAttributeValue("", 4259, "../assets/images/", 4259, 17, true);
#nullable restore
#line 88 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 4276, exr.Image2, 4276, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 4288, "\"", 4336, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 91 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                       Write(exr.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p><small>");
#nullable restore
#line 92 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                              Write(exr.Small2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                    <div class=\"image col-lg-4 col-sm-12\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4678, "\"", 4712, 2);
            WriteAttributeValue("", 4684, "../assets/images/", 4684, 17, true);
#nullable restore
#line 95 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 4701, exr.Image3, 4701, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 4713, "\"", 4761, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 98 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                       Write(exr.Title3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p><small>");
#nullable restore
#line 99 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                              Write(exr.Small3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 102 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                        <div data-id=\"2\" class=\"item d-none\">\r\n");
#nullable restore
#line 106 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                               foreach (ExampleActions ex in @Model.ExampleActions)
                             {
                                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                    if (@ex.Name!=null)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      <div class=\"titles\">\r\n                                    <h2>");
#nullable restore
#line 111 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                   Write(ex.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <p>");
#nullable restore
#line 112 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                  Write(ex.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\n");
#nullable restore
#line 114 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                      
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"actions\">\r\n                                    <div class=\"image col-lg-6 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 5788, "\"", 5795, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", "\r\n                                                src=\"", 5801, "\"", 5882, 2);
            WriteAttributeValue("", 5856, "../assets/images/", 5856, 17, true);
#nullable restore
#line 118 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 5873, ex.Image, 5873, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5883, "\"", 5889, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                                    <div class=\"title col-lg-6 col-md-6 col-sm-12\">\r\n                                        <h3>");
#nullable restore
#line 120 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                       Write(ex.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p>");
#nullable restore
#line 121 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                      Write(ex.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"icons\">\r\n");
#nullable restore
#line 123 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                      foreach (ActionsIcons item in @Model.ActionsIcons)
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                      <a");
            BeginWriteAttribute("href", " href=\"", 6408, "\"", 6415, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 6419, "\"", 6438, 1);
#nullable restore
#line 126 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 6427, item.Icon1, 6427, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><i");
            BeginWriteAttribute("class", "\r\n                                                    class=\"", 6446, "\"", 6518, 1);
#nullable restore
#line 127 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 6507, item.Icon2, 6507, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span>\r\n                                                   ");
#nullable restore
#line 128 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                              Write(item.Span);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 129 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                                
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                   

                                </div>
                                   </div>
                                <div class=""made"">
                                    <div class=""rigth"">
                                        <p>");
#nullable restore
#line 138 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                      Write(ex.MadeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"images\">\r\n                                        <div class=\"image col-lg-3 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 7231, "\"", 7238, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", "\r\n                                                    src=\"", 7244, "\"", 7334, 2);
            WriteAttributeValue("", 7303, "../assets/images/", 7303, 17, true);
#nullable restore
#line 142 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 7320, ex.MadeImage1, 7320, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7335, "\"", 7341, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <h5>");
#nullable restore
#line 143 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                               Write(ex.MadeImagename1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            </a>\r\n                                        </div>\r\n                                        <div class=\"image col-lg-3 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 7609, "\"", 7616, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", "\r\n                                                    src=\"", 7622, "\"", 7712, 2);
            WriteAttributeValue("", 7681, "../assets/images/", 7681, 17, true);
#nullable restore
#line 147 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 7698, ex.MadeImage2, 7698, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7713, "\"", 7719, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <h5>");
#nullable restore
#line 148 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                               Write(ex.MadeImagename2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            </a></div>\r\n                                        <div class=\"image col-lg-3 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 7945, "\"", 7952, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", "\r\n                                                    src=\"", 7958, "\"", 8048, 2);
            WriteAttributeValue("", 8017, "../assets/images/", 8017, 17, true);
#nullable restore
#line 151 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 8034, ex.MadeImage3, 8034, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8049, "\"", 8055, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <h5>");
#nullable restore
#line 152 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                               Write(ex.MadeImagename3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            </a></div>\r\n                                        <div class=\"image col-lg-3 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 8281, "\"", 8288, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", "\r\n                                                    src=\"", 8294, "\"", 8384, 2);
            WriteAttributeValue("", 8353, "../assets/images/", 8353, 17, true);
#nullable restore
#line 155 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 8370, ex.MadeImage4, 8370, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8385, "\"", 8391, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <h5>");
#nullable restore
#line 156 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                               Write(ex.MadeImagename4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                </h5>\r\n                                            </a></div>\r\n                                    </div>\r\n                                </div> \n");
#nullable restore
#line 162 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                             <div data-id=\"3\" class=\"item d-none\">\r\n                                <div class=\"titles\">\r\n                                    <h2>");
#nullable restore
#line 167 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                   Write(Model.ExpTitles.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <p>");
#nullable restore
#line 168 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                  Write(Model.ExpTitles.Descrptions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 170 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                               foreach (Item item in @Model.Items)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <div class=\"actions\">\r\n                                    <div class=\"image col-lg-6 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 9275, "\"", 9282, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", "\r\n                                                src=\"", 9288, "\"", 9371, 2);
            WriteAttributeValue("", 9343, "../assets/images/", 9343, 17, true);
#nullable restore
#line 174 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 9360, item.Image, 9360, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9372, "\"", 9378, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                    </div>\r\n                                    <div class=\"title col-lg-6 col-md-6 col-sm-12\">\r\n                                        <h3>");
#nullable restore
#line 177 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p>");
#nullable restore
#line 178 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"icons\"> \n");
#nullable restore
#line 180 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                             foreach (ActionsIcons item1 in @Model.ActionsIcons)
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                      <a");
            BeginWriteAttribute("href", " href=\"", 9947, "\"", 9954, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 9958, "\"", 9978, 1);
#nullable restore
#line 183 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 9966, item1.Icon1, 9966, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><i");
            BeginWriteAttribute("class", "\r\n                                                    class=\"", 9986, "\"", 10059, 1);
#nullable restore
#line 184 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 10047, item1.Icon2, 10047, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span>\r\n                                                   ");
#nullable restore
#line 185 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                              Write(item1.Span);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 186 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                                
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                    </div>\r\n\r\n                                </div>\n");
#nullable restore
#line 192 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                 
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                             <div data-id=\"4\" class=\"item d-none\">\r\n                                <div class=\"act\">\r\n");
#nullable restore
#line 197 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                foreach (Act act in @Model.Acts)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <div class=\"img col-lg-6 col-md-6 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 10786, "\"", 10793, 0);
            EndWriteAttribute();
            WriteLiteral("><img style=\"width: 300px;\"");
            BeginWriteAttribute("src", "\r\n                                                src=\"", 10821, "\"", 10903, 2);
            WriteAttributeValue("", 10876, "../assets/images/", 10876, 17, true);
#nullable restore
#line 200 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
WriteAttributeValue("", 10893, act.Image, 10893, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10904, "\"", 10910, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <p>");
#nullable restore
#line 201 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                          Write(act.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><small>");
#nullable restore
#line 201 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                                              Write(act.Small);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </a></div>\n");
#nullable restore
#line 203 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                      
                                </div>
                            </div>

                    </div>

                </div>
            </div>
        </div>

    </section>
    <!--get-->
   <section id=""get"">
        <div class=""get"">
            <div class=""container"">
                <div class=""row"">  
                    <div class=""title"">  
                        <h3> ");
#nullable restore
#line 221 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                        Write(Model.Get.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                       \r\n                    </div>\r\n                    <div class=\"text\">\r\n                        <p>");
#nullable restore
#line 225 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                      Write(Model.Get.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        \r\n                    </div>\r\n                    <a href=\"../Html/login.html\">");
#nullable restore
#line 228 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Example\Examples.cshtml"
                                            Write(Model.Get.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                 
                </div>
            </div>
        </div>
    </section>
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""
            integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.min.js""
            integrity=""sha512-XtmMtDEcNz2j7ekrtHvOVR4iwwaD6o/FUJe6+Zq+HgcCsk3kj4uSQQR8weQ2QVj1o0Pk6PwYLohm206ZzNfubg==""
            crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.3.0/mdb.min.js""></script>
    <script src=""https://unpkg.com/aos@2.3.1/dist/aos.js""></script>
    <script>
        AOS.init();
    </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.min.js""></script>
    <script src=""../assets/javascript/products.js""></script>
    <script src=""../assets/javascript/example.js""></s");
            WriteLiteral("cript>\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExampleVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
