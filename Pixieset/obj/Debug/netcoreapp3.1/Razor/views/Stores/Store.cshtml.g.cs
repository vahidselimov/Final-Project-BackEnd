#pragma checksum "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac6896ac9e22c8fe77d4cfda2029828b6b8ba619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Stores_Store), @"mvc.1.0.view", @"/views/Stores/Store.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6896ac9e22c8fe77d4cfda2029828b6b8ba619", @"/views/Stores/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b0a73d6c4011eedc1b46aaa0a929b55221db1b", @"/views/_ViewImports.cshtml")]
    #nullable restore
    public class views_Stores_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Acoount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6896ac9e22c8fe77d4cfda2029828b6b8ba6194437", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
     
    ViewData["Title"] = "Store";

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"">
    <!-- Font Awesome -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" rel=""stylesheet"" />
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"" rel=""stylesheet"" />
    <!-- MDB -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.3.0/mdb.min.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""../assets/css/store.css"">
");
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
            WriteLiteral(@"   <main>
        <section id=""first"">
            <div class=""studio"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""titles col-lg-6"">
                            <div class=""image""><img");
            BeginWriteAttribute("src", " src=\"", 1191, "\"", 1241, 2);
            WriteAttributeValue("", 1197, "../assets/images/", 1197, 17, true);
#nullable restore
#line 26 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 1214, Model.StoreFirst.MiniImage, 1214, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1242, "\"", 1248, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p>");
#nullable restore
#line 27 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                              Write(Model.StoreFirst.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n                            <div class=\"title\">\r\n                                <h3>");
#nullable restore
#line 31 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                               Write(Model.StoreFirst.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 32 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                              Write(Model.StoreFirst.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p><a href=\"../Html/login.html\">");
#nullable restore
#line 33 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                                            Write(Model.StoreFirst.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"images col-lg-6\"><img");
            BeginWriteAttribute("src", " src=\"", 1751, "\"", 1800, 2);
            WriteAttributeValue("", 1757, "../assets/images/", 1757, 17, true);
#nullable restore
#line 36 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 1774, Model.StoreFirst.BigImage, 1774, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1801, "\"", 1807, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>

                    </div>
                </div>
            </div>
        </section>
        <section id=""auto"">
            <div class=""auto"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""title"">
                            <h3>");
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(Model.StoreAutoTitle.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h3>\r\n                            <strong>");
#nullable restore
#line 49 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                               Write(Model.StoreAutoTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <p>");
#nullable restore
#line 50 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                          Write(Model.StoreAutoTitle.Descrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div class=\"images\">\r\n                        <div class=\"image1 col-lg-4 col-md-4 col-sm-12\"><img");
            BeginWriteAttribute("src", " src=\"", 2515, "\"", 2566, 2);
            WriteAttributeValue("", 2521, "../assets/images/", 2521, 17, true);
#nullable restore
#line 55 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 2538, Model.StoreAutoTitle.Image1, 2538, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 2567, "\"", 2606, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"image2 col-lg-4 col-md-4 col-sm-12\"><img");
            BeginWriteAttribute("src", " src=\"", 2692, "\"", 2743, 2);
            WriteAttributeValue("", 2698, "../assets/images/", 2698, 17, true);
#nullable restore
#line 57 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 2715, Model.StoreAutoTitle.Image2, 2715, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 2744, "\"", 2783, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"image3 col-lg-4 col-md-4 col-sm-12\"><img");
            BeginWriteAttribute("src", " src=\"", 2869, "\"", 2920, 2);
            WriteAttributeValue("", 2875, "../assets/images/", 2875, 17, true);
#nullable restore
#line 59 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 2892, Model.StoreAutoTitle.Image3, 2892, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 2921, "\"", 2960, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    </div>\r\n                    <div class=\"client\">\r\n                        <div class=\"row\">\r\n                            <div class=\"flex\">\r\n");
#nullable restore
#line 65 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                 foreach (StoreAutoSpan span in Model.StoreAutoSpan)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <span>");
#nullable restore
#line 67 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                    Write(span.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <hr>\n");
#nullable restore
#line 69 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                        \r\n");
#nullable restore
#line 75 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                            foreach (StoreAutoTexts texts in Model.StoreAutoTexts)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div class=\"text col-lg-4\">\r\n                                <h3>");
#nullable restore
#line 78 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                               Write(texts.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 79 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                              Write(texts.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </p>\r\n                            </div>\n");
#nullable restore
#line 82 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"partner\">\r\n                        <h3>");
#nullable restore
#line 86 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                       Write(Model.StoreAutoImagesName.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <div class=\"images\">");
#nullable restore
#line 87 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                             foreach (StoreAutoImages storeAuto in Model.StoreAutoImages )
                                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <img");
            BeginWriteAttribute("src", " src=\"", 4304, "\"", 4343, 2);
            WriteAttributeValue("", 4310, "../assets/images/", 4310, 17, true);
#nullable restore
#line 89 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 4327, storeAuto.Image, 4327, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 4344, "\"", 4383, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 91 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>

            </div>
        </section>
        <section id=""com"">
            <div class=""com"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""titles col-lg-6"">
                            <h2>");
#nullable restore
#line 102 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(Model.StoreCom.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <h3>");
#nullable restore
#line 103 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(Model.StoreCom.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 104 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                          Write(Model.StoreCom.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"image col-lg-6\"><img");
            BeginWriteAttribute("src", " src=\"", 4995, "\"", 5039, 2);
            WriteAttributeValue("", 5001, "../assets/images/", 5001, 17, true);
#nullable restore
#line 106 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 5018, Model.StoreCom.Image, 5018, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5040, "\"", 5046, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""product"">
            <div class=""product"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""title"">
                            <h2>");
#nullable restore
#line 117 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(Model.StoreProductTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <h3>");
#nullable restore
#line 118 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(Model.StoreProductTitle.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 119 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                          Write(Model.StoreProductTitle.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"images\">\r\n\r\n                            <div class=\"row\">\r\n                               \r\n");
#nullable restore
#line 125 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                               foreach (StoreProductImage image in @Model.StoreProductImage)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <div class=\"image col-lg-4\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 5965, "\"", 6018, 2);
            WriteAttributeValue("", 5971, "../assets/images/hoverimage/", 5971, 28, true);
#nullable restore
#line 128 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 5999, image.FrontPicture, 5999, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                        alt=\"Card Back\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 6119, "\"", 6171, 2);
            WriteAttributeValue("", 6125, "../assets/images/hoverimage/", 6125, 28, true);
#nullable restore
#line 130 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 6153, image.BackPicture, 6153, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"img-top\" alt=\"Card Front\">\r\n                                    <p>");
#nullable restore
#line 132 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                  Write(image.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\n");
#nullable restore
#line 134 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            </div>\r\n        </section>\r\n        <section id=\"tools\">\r\n");
#nullable restore
#line 143 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
            foreach (StoreTools tools in @Model.StoreTools)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"tool\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"titles col-lg-6 col-md-4 col-sm-12\">\r\n                            <h2>");
#nullable restore
#line 149 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(tools.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <h3>");
#nullable restore
#line 150 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(tools.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 151 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                          Write(tools.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"images col-lg-6 col-md-4 col-sm-12\"><img");
            BeginWriteAttribute("src", " src=\"", 7111, "\"", 7146, 2);
            WriteAttributeValue("", 7117, "../assets/images/", 7117, 17, true);
#nullable restore
#line 153 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 7134, tools.Image, 7134, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 7147, "\"", 7186, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    </div>\r\n                </div>\r\n            </div>\n");
#nullable restore
#line 158 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
              
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n        </section>\r\n        <section id=\"cards\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"title\">\r\n");
#nullable restore
#line 166 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                     foreach (Cards cards1 in @Model.Cards)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                         if (cards1.Name != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>");
#nullable restore
#line 170 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                           Write(cards1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n");
#nullable restore
#line 171 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 175 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                 foreach (Cards cards in @Model.Cards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card col-lg-4 col-md-6  col-sm-12\">\r\n                        <div class=\"product\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 7969, "\"", 7976, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"image\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 8073, "\"", 8108, 2);
            WriteAttributeValue("", 8079, "../assets/images/", 8079, 17, true);
#nullable restore
#line 181 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 8096, cards.Image, 8096, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                     alt=\"", 8109, "\"", 8153, 0);
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 182 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                             Write(cards.Span);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"text\">\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 186 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                   Write(cards.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                                <div class=\"learn\">\r\n                                    <h5>");
#nullable restore
#line 190 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                   Write(cards.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i");
            BeginWriteAttribute("class", " class=\"", 8557, "\"", 8577, 1);
#nullable restore
#line 190 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
WriteAttributeValue("", 8565, cards.Icons, 8565, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></h5>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 195 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n      <section id=\"get\">\r\n        <div class=\"get\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"title\">\r\n                        <h3> ");
#nullable restore
#line 206 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                        Write(Model.Get.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                    </div>\r\n                    <div class=\"text\">\r\n                        <p>");
#nullable restore
#line 210 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                      Write(Model.Get.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 213 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                     if (User.Identity.IsAuthenticated)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6896ac9e22c8fe77d4cfda2029828b6b8ba61929903", async() => {
#nullable restore
#line 215 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
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
#line 216 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6896ac9e22c8fe77d4cfda2029828b6b8ba61931744", async() => {
#nullable restore
#line 220 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                                                                    Write(Model.Get.Link);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 221 "C:\Users\Asus\Desktop\Pixieset\Pixieset\views\Stores\Store.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n \r\n    </section>\r\n    </main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
