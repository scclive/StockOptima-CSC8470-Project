#pragma checksum "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3b6456c43772693b43a7dac4310a3f43f1871ed20f6c17900f0cb03b60f47634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_GeneralReports), @"mvc.1.0.view", @"/Views/Reports/GeneralReports.cshtml")]
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
#line 1 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\_ViewImports.cshtml"
using StockOptima

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\_ViewImports.cshtml"
using StockOptima.Models

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
 using StockOptima.Services.Database

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
 using StockOptima.Utils

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
 using System.Globalization

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
 using StockOptima.Models.Database

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
 using StockOptima.Utils.Formatting

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3b6456c43772693b43a7dac4310a3f43f1871ed20f6c17900f0cb03b60f47634", @"/Views/Reports/GeneralReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c33ef2b6517d892f6f972773faae9fd196838fb4bb9b5a4832c2b26cba2f7c07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reports_GeneralReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StockOptima.Operations.FilterOperation>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("normal-text-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GeneralReports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("simple-form bigger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
  
    ViewBag.Title = "Reports";
    ViewBag.PreviousPage = "";
    Layout = "_Layout";

    SaleInfo[] sales = await _salesService.GetSales(Model.Start, Model.End, Model.Usernames);

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h3>\n    Reports");
            Write(
#nullable restore
#line 18 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
             Model.Start != DateTime.MinValue ? " from " + Model.Start.FormatShortDate() : ""

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n    ");
            Write(
#nullable restore
#line 19 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
      Model.End != DateTime.MaxValue ? " up to " + Model.End.FormatShortDate() : ""

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
</h3>

<div style=""margin-bottom: 10px"">
    <button class=""btn-primary btn-group-toggle"" type=""button"" data-toggle=""collapse"" data-target=""#filters"" aria-navigation=""Toggle filters"">Toggle filters</button>
</div>

<div style=""margin-bottom: 15px"">
    <div id=""filters"" class=""collapse"">
        <b>Filters</b>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b6456c43772693b43a7dac4310a3f43f1871ed20f6c17900f0cb03b60f476348721", async() => {
                WriteLiteral("\n            <label class=\"form-label\" for=\"startDateInput\">Start Date (inclusive): </label>\n            <input id=\"startDateInput\" name=\"start\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 1190, "\"", 1275, 1);
                WriteAttributeValue("", 1198, 
#nullable restore
#line 31 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                                                                         Model.Start == DateTime.MinValue ? "" : Model.Start.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
                , 1198, 77, false);
                EndWriteAttribute();
                WriteLiteral(@">
            <span uk-icon=""icon: close"" onclick=""clearValue(startDateInput); submitBtn.click()""></span><br>

            <label class=""form-label"" for=""endDateInput"">End Date (inclusive): </label>
            <input id=""endDateInput"" name=""end"" type=""date""");
                BeginWriteAttribute("value", " value=\"", 1534, "\"", 1615, 1);
                WriteAttributeValue("", 1542, 
#nullable restore
#line 35 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                                                                     Model.End == DateTime.MaxValue ? "" : Model.End.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
                , 1542, 73, false);
                EndWriteAttribute();
                WriteLiteral(">\n            <span uk-icon=\"icon: close\" onclick=\"clearValue(endDateInput); submitBtn.click()\"></span><br>\n            <br>\n\n            <button id=\"submitBtn\" class=\"btn-secondary\" type=\"submit\">Apply Filters</button>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b6456c43772693b43a7dac4310a3f43f1871ed20f6c17900f0cb03b60f4763411013", async() => {
                    WriteLiteral("\n                <button class=\"btn-secondary\" type=\"button\">Clear Filters</button>\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<div>\n    <h4>Summary</h4>\n    <p>\n        <b>Sales count:</b> ");
            Write(
#nullable restore
#line 50 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                             sales.Length

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("<br/>\n        <b>Total sales:</b> ");
            Write(
#nullable restore
#line 51 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                              ((float)sales.Sum(o => o.TotalPrice)).ToString(CultureInfo.InvariantCulture)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("<br/>\n        <b>Total profit:</b> ");
            Write(
#nullable restore
#line 52 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                               ((float)sales.Sum(o => o.Profit)).ToString(CultureInfo.InvariantCulture)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
    </p>

    <div class=""card-bottom-margin"">
        <div class=""card chart column-chart"">
            <div id=""dailySalesColumnChart""></div>
        </div>
    </div>

    <h4>Payment Methods</h4>
    <div class=""card-deck"">
        <div class=""card-bottom-margin"">
            <div class=""card chart pie-chart"">
                <div id=""paymentMethodsCountPieChart""></div>
            </div>
        </div>

        <div class=""card-bottom-margin"">
            <div class=""card chart pie-chart"">
                <div id=""paymentMethodsTotalPieChart""></div>
            </div>
        </div>

        <div class=""card-bottom-margin"">
            <div class=""card chart pie-chart"">
                <div id=""paymentMethodsProfitPieChart""></div>
            </div>
        </div>
    </div>

    <h4>Employees</h4>
    <div class=""card-deck"">
        <div class=""card-bottom-margin"">
            <div class=""card chart pie-chart"">
                <div id=""employeesCountPieChart""></div>
            </div>
        </div>

 ");
            WriteLiteral(@"       <div class=""card-bottom-margin"">
            <div class=""card chart pie-chart"">
                <div id=""employeesTotalPieChart""></div>
            </div>
        </div>

        <div class=""card-bottom-margin"">
            <div class=""card chart pie-chart"">
                <div id=""employeesProfitPieChart""></div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

    <script>
        const dailySalesColumnChart = document.getElementById('dailySalesColumnChart');
        const paymentMethodsCountPieChart = document.getElementById('paymentMethodsCountPieChart');
        const paymentMethodsTotalPieChart = document.getElementById('paymentMethodsTotalPieChart');
        const paymentMethodsProfitPieChart = document.getElementById('paymentMethodsProfitPieChart');
        const employeesCountPieChart = document.getElementById('employeesCountPieChart');
        const employeesTotalPieChart = document.getElementById('employeesTotalPieChart');
        const employeesProfitPieChart = document.getElementById('employeesProfitPieChart');
        
        const startDateInput = document.getElementById('startDateInput');
        const endDateInput = document.getElementById('endDateInput');
        const submitBtn = document.getElementById('submitBtn');
    
        google.charts.load('curre");
                WriteLiteral("nt\', {\'packages\':[\'corechart\']});\n        google.charts.setOnLoadCallback(drawAllCharts);\n        \n        function drawAllCharts(){\n            let charts = [\n                // Total Sales\n                function() {\n                    let data;\n\n");
#nullable restore
#line 131 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                      
                        DateTime totalSalesStart = Model.Start != DateTime.MinValue ? Model.Start : new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        DateTime totalSalesEnd = Model.End != DateTime.MaxValue ? Model.End : DateTime.Now;

                        TimeSpan totalTime = totalSalesEnd - totalSalesStart;

                        if (totalTime <= TimeSpan.FromDays(30))
                        {
                            

#line default
#line hidden
#nullable disable

                WriteLiteral("                            ");
                WriteLiteral(" data = google.visualization.arrayToDataTable(\n");
                Write(
#nullable restore
#line 141 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                             Html.Raw(JsUtils.BuildChartData("Day", "Sales", "Profit", 
                                _salesService.GetDailySalesAndProfit(totalSalesStart, totalSalesEnd, sales)
                                    .Select(o => new KeyValuePair<string, (double, double)>(o.Key.FormatShortDate(), o.Value))))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("                            ");
                WriteLiteral(");\n                            ");
                WriteLiteral("finishColumnChart(dailySalesColumnChart, data,  \'Daily sales (");
                Write(
#nullable restore
#line 145 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                                                                                             totalSalesStart.FormatShortDate()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" - ");
                Write(
#nullable restore
#line 145 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                                                                                                                                  totalSalesEnd.FormatShortDate()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(")\');\n");
#nullable restore
#line 146 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable

                WriteLiteral("                            ");
                WriteLiteral(" data = google.visualization.arrayToDataTable(\n");
                Write(
#nullable restore
#line 151 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                             Html.Raw(JsUtils.BuildChartData("Month", "Sales", "Profit", 
                                _salesService.GetMonthlySalesAndProfit(totalSalesStart, totalSalesEnd, sales)
                                    .Select(o => new KeyValuePair<string, (double, double)>(o.Key.FormatShortDate(), o.Value))))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("                            ");
                WriteLiteral(");\n                            ");
                WriteLiteral("finishColumnChart(dailySalesColumnChart, data,  \'Monthly sales (");
                Write(
#nullable restore
#line 155 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                                                                                               totalSalesStart.FormatShortDate()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" - ");
                Write(
#nullable restore
#line 155 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                                                                                                                                    totalSalesEnd.FormatShortDate()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(")\');                                                                                                                                                                                                                      \n");
#nullable restore
#line 156 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable

                WriteLiteral("                },\n                \n                // Payment Methods\n                function() {\n                    let data = google.visualization.arrayToDataTable(\n                        ");
                Write(
#nullable restore
#line 163 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                         Html.Raw(JsUtils.BuildChartData("Method", "Sales Count", _salesService.CountSalesPerProperty(sales, o => o.Method.Name)))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    );
                    finishPieChart(paymentMethodsCountPieChart, data,  'Payment methods / Sales number');
                },
                
                function() {
                    let data = google.visualization.arrayToDataTable(
                        ");
                Write(
#nullable restore
#line 170 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                         Html.Raw(JsUtils.BuildChartData("Method", "Sales", _salesService.SumSalesPerProperty(sales, o => o.Method.Name)))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    );
                    finishPieChart(paymentMethodsTotalPieChart, data,  'Payment methods / Sales');
                },
                
                function() {
                    let data = google.visualization.arrayToDataTable(
                        ");
                Write(
#nullable restore
#line 177 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                         Html.Raw(JsUtils.BuildChartData("Method", "Profit", _salesService.SumSalesProfitPerProperty(sales, o => o.Method.Name)))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    );
                    finishPieChart(paymentMethodsProfitPieChart, data,  'Payment methods / Profit');
                },
                
                // Employees
                function() {
                    let data = google.visualization.arrayToDataTable(
                        ");
                Write(
#nullable restore
#line 185 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                         Html.Raw(JsUtils.BuildChartData("Employee", "Sales Count", _salesService.CountSalesPerProperty(sales, o => o.Seller.Name)))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    );
                    finishPieChart(employeesCountPieChart, data,  'Employee / Sales number');
                },
                
                function() {
                    let data = google.visualization.arrayToDataTable(
                        ");
                Write(
#nullable restore
#line 192 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                         Html.Raw(JsUtils.BuildChartData("Employee", "Sales", _salesService.SumSalesPerProperty(sales, o => o.Seller.Name)))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    );
                    finishPieChart(employeesTotalPieChart, data,  'Employee / Sales');
                },
                
                function() {
                    let data = google.visualization.arrayToDataTable(
                        ");
                Write(
#nullable restore
#line 199 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                         Html.Raw(JsUtils.BuildChartData("Employee", "Profit", _salesService.SumSalesProfitPerProperty(sales, o => o.Seller.Name)))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    );
                    finishPieChart(employeesProfitPieChart, data,  'Employee / Profit');
                },
            ];
            
            for(let i = 0; i < charts.length; i++) {
                charts[i]();
            }
        }
        
        function finishPieChart(target, data, title) {
            let options = {
                title: title,
            }
            let chart = new google.visualization.PieChart(target);        
            chart.draw(data,  options);
        }
        
        function finishColumnChart(target, data, title) {
            let options = {
                title: title,
            }
            let chart = new google.visualization.ColumnChart(target);        
            chart.draw(data,  options);
        }
        
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 1 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
        SalesService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 1 "C:\Users\Lynx\Desktop\Assignments\Bilal Hassan Assignments - 5\CSC8470 - Server-side Web Technology\A2\New\InventoryWebApplication-master\InventoryWebApplication\Views\Reports\GeneralReports.cshtml"
                     _salesService

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StockOptima.Operations.FilterOperation> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
