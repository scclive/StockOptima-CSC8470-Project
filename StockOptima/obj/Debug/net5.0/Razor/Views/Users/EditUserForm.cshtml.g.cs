#pragma checksum "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06b454bceaaaaaa56153ea449787dc6727a48b443b68282582c5b083296c34de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_EditUserForm), @"mvc.1.0.view", @"/Views/Users/EditUserForm.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\_ViewImports.cshtml"
using StockOptima

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\_ViewImports.cshtml"
using StockOptima.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
 using StockOptima.Models.Database

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
 using StockOptima.Services.Database

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"06b454bceaaaaaa56153ea449787dc6727a48b443b68282582c5b083296c34de", @"/Views/Users/EditUserForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c33ef2b6517d892f6f972773faae9fd196838fb4bb9b5a4832c2b26cba2f7c07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_EditUserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StockOptima.Operations.MessageIdOperation>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("simple-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
  
    ViewBag.Title = "Edit user";
    ViewBag.PreviousPage = "users";
    Layout = "_FormsLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n");
#nullable restore
#line 12 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
  
    User user = await _databaseService.GetById(Model.Id);

#line default
#line hidden
#nullable disable

            WriteLiteral("\n");
#nullable restore
#line 16 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
 if (user is null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h1>User not found</h1>\n");
#nullable restore
#line 19 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b454bceaaaaaa56153ea449787dc6727a48b443b68282582c5b083296c34de6842", async() => {
                WriteLiteral("\n        <div class=\"form-section\">\n            <label class=\"form-label\" for=\"idInput\">Id: </label>\n            <input");
                BeginWriteAttribute("value", " value=\"", 612, "\"", 628, 1);
                WriteAttributeValue("", 620, 
#nullable restore
#line 25 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                           user.Id

#line default
#line hidden
#nullable disable
                , 620, 8, false);
                EndWriteAttribute();
                WriteLiteral(" readonly disabled type=\"text\" id=\"idInput\">\n            <br>\n\n            <label class=\"form-label\" for=\"nameInput\">Name: </label>\n            <input");
                BeginWriteAttribute("value", " value=\"", 779, "\"", 797, 1);
                WriteAttributeValue("", 787, 
#nullable restore
#line 29 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                           user.Name

#line default
#line hidden
#nullable disable
                , 787, 10, false);
                EndWriteAttribute();
                WriteLiteral(@" name=""name"" type=""text"" id=""nameInput"">
            <br>

            <label class=""form-label"" for=""passwordInput"">Password: </label>
            <input name=""password"" type=""text"" id=""passwordInput"" placeholder=""empty to keep password"">
            <br>

            <label class=""form-label"" for=""roleInput"">Role: </label>
            <select name=""role"" id=""roleInput"">
");
#nullable restore
#line 38 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                 foreach (string possibleRole in Role.AvailableRoles)
                {
                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 40 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                     if (possibleRole == user.Role)
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b454bceaaaaaa56153ea449787dc6727a48b443b68282582c5b083296c34de9658", async() => {
                    Write(
#nullable restore
#line 42 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                                                                Role.GetFormattedName(possibleRole)

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral(
#nullable restore
#line 42 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                                        possibleRole

#line default
#line hidden
#nullable disable
                );
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 43 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b454bceaaaaaa56153ea449787dc6727a48b443b68282582c5b083296c34de12610", async() => {
                    Write(
#nullable restore
#line 46 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                                                       Role.GetFormattedName(possibleRole)

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral(
#nullable restore
#line 46 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                                        possibleRole

#line default
#line hidden
#nullable disable
                );
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 47 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 47 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                     
                }

#line default
#line hidden
#nullable disable

                WriteLiteral(@"            </select>
        </div>

        <div>
            <button class=""btn-primary"" type=""submit"">Save</button>
            <a href=""/users"">
                <button class=""btn-primary"" type=""button"">Discard Changes</button>
            </a>
            <button class=""btn-primary"" id=""btnDelete"" type=""button"">Delete</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 470, "/users/edit/", 470, 12, true);
            AddHtmlAttributeValue("", 482, 
#nullable restore
#line 22 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                                                                                        Model.Id

#line default
#line hidden
#nullable disable
            , 482, 9, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        $(\'#btnDelete\').click(function() {\n            sendDeleteRequest(\"/users/delete/");
                Write(
#nullable restore
#line 65 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                                              Model.Id

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\");\n            redirectTo(\"/users\");\n        });\n    </script>\n");
            }
            );
#nullable restore
#line 69 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
 
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 4 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
        DatabaseService<User>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\Project\StockOptima-CSC8470-Project\StockOptima\Views\Users\EditUserForm.cshtml"
                              _databaseService

#line default
#line hidden
#nullable disable
         { get; private set; }
         = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StockOptima.Operations.MessageIdOperation> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
