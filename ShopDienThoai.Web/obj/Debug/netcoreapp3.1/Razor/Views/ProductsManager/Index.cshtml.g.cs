#pragma checksum "C:\Users\Nhung\Desktop\ShopDienThoai\ShopDienThoai.Web\Views\ProductsManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e613ef182168abf4726c249d821bb24606f47e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductsManager_Index), @"mvc.1.0.view", @"/Views/ProductsManager/Index.cshtml")]
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
#line 1 "C:\Users\Nhung\Desktop\ShopDienThoai\ShopDienThoai.Web\Views\_ViewImports.cshtml"
using ShopDienThoai.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nhung\Desktop\ShopDienThoai\ShopDienThoai.Web\Views\_ViewImports.cshtml"
using ShopDienThoai.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e613ef182168abf4726c249d821bb24606f47e", @"/Views/ProductsManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c52e1d766179d0170e4d1ea1f645337f6aab52", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductsManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addEditProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootbox.js/bootbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ekko-lightbox/ekko-lightbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/tinymce/tinymce.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/css/dataTables.bootstrap4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ekko-lightbox/ekko-lightbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nhung\Desktop\ShopDienThoai\ShopDienThoai.Web\Views\ProductsManager\Index.cshtml"
  
    ViewBag.Title = "Quản lý sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 mb-3"">
        <a href=""javascript:void(0);"" class=""btn btn-info""
           onclick=""AddEditProduct()""><i class=""fas fa-plus""></i> Thêm sản phẩm</a>
    </div>
</div>
<table id=""productsTable"" class=""table table-bordered table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th>Tên</th>
            <th>Hình ảnh</th>
            <th>Thương hiệu</th>
            <th>Thông số kỹ thuật</th>
            <th>Giá</th>
            <th>Tồn kho</th>
            <th>Hành động</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

<!-- Modal -->
<div id=""addEditProduct"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-xl"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e8539", async() => {
                WriteLiteral(@"
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title""></h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <input hidden id=""ProductId"" name=""ProductId"">
                    <div id=""imgsdata""></div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                        </div>
                        <div class=""col-10"" id=""imgsPreview"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Ảnh sản phẩm:</label>
                        </div>
                        <div class=""col-10"">
                            <div class=""custom-file"">
                                <input ");
                WriteLiteral(@"id=""ProductImages"" name=""ProductImages"" type=""file"" class=""custom-file-input form-control"" data-rule-required=""true"" multiple>
                                <label class=""custom-file-label"" for=""ProductImages"">Choose file</label>
                            </div>
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Tên sản phẩm:</label>
                        </div>
                        <div class=""col-10"">
                            <input type=""text"" id=""ProductName"" name=""ProductName"" class=""form-control"" data-rule-required=""true"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Giá (₫):</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""numbe");
                WriteLiteral(@"r"" id=""ProductPrice"" name=""ProductPrice"" class=""form-control"" data-rule-required=""true"">
                        </div>
                        <div class=""col-2"">
                            <label>Số lượng (cái):</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""number"" id=""ProductRemain"" name=""ProductRemain"" class=""form-control"" data-rule-required=""true"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Thương hiệu:</label>
                        </div>
                        <div class=""col-4"">
                            <select id=""ProductBrandId"" name=""ProductBrandId"" class=""form-control"" data-rule-required=""true"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e11914", async() => {
                    WriteLiteral("Chọn thương hiệu");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""col-2"">
                            <label>Danh mục:</label>
                        </div>
                        <div class=""col-4"">
                            <select id=""ProductCategoryId"" name=""ProductCategoryId"" class=""form-control"" data-rule-required=""true"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e13571", async() => {
                    WriteLiteral("Chọn danh mục");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>CPU:</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""text"" id=""ProductCPU"" name=""ProductCPU"" class=""form-control"" data-rule-required=""true"">
                        </div>
                        <div class=""col-2"">
                            <label>Màn hình:</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""text"" id=""ProductScreen"" name=""ProductScreen"" class=""form-control"" data-rule-required=""true"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Hệ điều hành:</label>
               ");
                WriteLiteral(@"         </div>
                        <div class=""col-10"">
                            <input type=""text"" id=""ProductOS"" name=""ProductOS"" class=""form-control"" data-rule-required=""true"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Camera sau:</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""text"" id=""ProductRearCamera"" name=""ProductRearCamera"" class=""form-control"" data-rule-required=""true"">
                        </div>
                        <div class=""col-2"">
                            <label>Camera trước:</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""text"" id=""ProductFrontCamera"" name=""ProductFrontCamera"" class=""form-control"" data-rule-required=""true"">
                        </div>
           ");
                WriteLiteral(@"         </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Ram (GB):</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""number"" id=""ProductRam"" name=""ProductRam"" class=""form-control"" data-rule-required=""true"">
                        </div>
                        <div class=""col-2"">
                            <label>Rom (GB):</label>
                        </div>
                        <div class=""col-4"">
                            <input type=""number"" id=""ProductRom"" name=""ProductRom"" class=""form-control"" data-rule-required=""true"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-2"">
                            <label>Bài viết mô tả:</label>
                        </div>
                        <div class=""col-10"">
                ");
                WriteLiteral(@"            <textarea id=""ProductDescription"" name=""ProductDescription"" class=""form-control"" data-rule-required=""true""></textarea>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <a href=""javascript:;"" class=""btn btn-primary"" onclick=""product.save()"">Lưu</a>
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Huỷ</button>
                    </div>

                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e19829", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e20111", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e21271", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e22431", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e23591", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e25726", async() => {
                    WriteLiteral(@"
        <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/5.4.0/bootbox.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/ekko-lightbox/5.3.0/ekko-lightbox.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/tinymce/4.9.11/tinymce.min.js""></script>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        document.getElementById(""ProductImages"").addEventListener(""change"", readFiles);

        $(document).on('click', '[data-toggle=""lightbox""]', function (event) {
            event.preventDefault();
            $(this).ekkoLightbox();
        });

        $('#ProductImages').on('change', function () {
            var fileLabel = $(this).next('.custom-file-label');
            var files = $(this)[0].files;
            if (files.length > 1) {
                fileLabel.html(files.length + ' tập tin được chọn');
            }
            else if (files.length == 1) {
                fileLabel.html(files[0].name);
            }
        });

        tinymce.init({
            selector: 'textarea',
            theme: 'modern',
            plugins: ['advlist autolink lists link image charmap print preview hr anchor pagebreak',
                'searchreplace wordcount visualblocks visualchars code fullscreen',
                'insertdatetime media nonbreaking save table cont");
                WriteLiteral(@"extmenu directionality',
                'emoticons paste textcolor colorpicker textpattern imagetools'
            ],
            toolbar1: 'insertfile undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image',
            toolbar2: 'print preview media | forecolor backcolor emoticons',
            image_advtab: true,
            height: ""400""
        });
    </script>
");
            }
            );
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e29043", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09e613ef182168abf4726c249d821bb24606f47e29325", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09e613ef182168abf4726c249d821bb24606f47e30568", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e613ef182168abf4726c249d821bb24606f47e32787", async() => {
                    WriteLiteral("\r\n        <link href=\"https://cdn.datatables.net/1.10.21/css/dataTables.bootstrap4.min.css\" rel=\"stylesheet\" />\r\n        <link href=\"https://cdnjs.cloudflare.com/ajax/libs/ekko-lightbox/5.3.0/ekko-lightbox.css\" rel=\"stylesheet\" />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        .remove-image {
            display: none;
            position: absolute;
            border-radius: 10em;
            padding: 2px 6px 3px;
            text-decoration: none;
            font: 700 21px/20px sans-serif;
            background: #555;
            border: 3px solid #fff;
            color: #FFF;
            box-shadow: 0 2px 6px rgba(0,0,0,0.5), inset 0 2px 4px rgba(0,0,0,0.3);
            text-shadow: 0 1px 2px rgba(0,0,0,0.5);
            -webkit-transition: background 0.5s;
            transition: background 0.5s;
        }

        .remove-image:hover {
            background: #E54E4E;
            padding: 3px 7px 5px;
        }

        .remove-image:active {
            background: #E54E4E;
        }
    </style>
");
            }
            );
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
