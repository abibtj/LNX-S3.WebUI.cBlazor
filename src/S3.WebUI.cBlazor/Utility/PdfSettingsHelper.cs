
using PuppeteerSharp;
using PuppeteerSharp.Media;
using S3.WebUI.cBlazor.Models;
using S3.WebUI.cBlazor.Utility;
using System;
using System.Threading.Tasks;
//using IronPdf;

public static class PdfGenerator
{
    public static async Task GenerateAsync(ClassReport classReport, Class selectedClass, int session, string[] classSubjects)
    {
        try
        {
            //Renderer.RenderHtmlAsPdf("<h1>Hello World<h1>").SaveAs("test.pdf");

            //var renderer = new HtmlToPdf();
            //var pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            //pdf.SaveAs("test.pdf");

            Console.WriteLine("Inside Generator");
            //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(classSubjects, new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase }));


            // downloads chromium to a temp folder, you can also specify a specific version, or a location where it should look for chromium.
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            Console.WriteLine("Downloaded Browser");

            using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false
            });

            Console.WriteLine("Set headless = false");

            using var page = await browser.NewPageAsync();
            Console.WriteLine("Executed: using var page = await browser.NewPageAsync();");
            var reportCardString = PdfReportCardHtmlTemplate.GetHTMLString(classReport, selectedClass, session, classSubjects);
            Console.WriteLine("Executed: reportCardString as follows:");
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(reportCardString, new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase }));
            await page.SetContentAsync(reportCardString);
            Console.WriteLine("Executed: await page.SetContentAsync(reportCardString);");
            await page.GetContentAsync();
            Console.WriteLine("Executed: await page.GetContentAsync();");
            await page.PdfAsync("ReportCard.pdf", new PdfOptions
            {
                DisplayHeaderFooter = false,
                Format = PaperFormat.A4,
                Landscape = true,
            });

            Console.WriteLine("End of Generator");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}



//using DinkToPdf;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using S3.WebUI.cBlazor.Models;

//namespace S3.WebUI.cBlazor.Utility
//{
//    public static class PdfSettingsHelper
//    {
//        public static GlobalSettings GetGlobalSettings()
//        {
//            return new GlobalSettings
//            {
//                ColorMode = ColorMode.Color,
//                Orientation = Orientation.Landscape,
//                PaperSize = PaperKind.A4,
//                Margins = new MarginSettings { Top = 10 },
//                DocumentTitle = "Report Card"
//                //Out = @"D:\PDFCreator\Employee_Report.pdf"
//            };
//        }

//        public static ObjectSettings GetObjectSettings(ClassReport classReport, Class selectedClass, int session, string[] classSubjects)
//        {
//            var pdfStyleSheetPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\css", "pdf-report-card.css");

//            return new ObjectSettings
//            {
//                PagesCount = false,
//                HtmlContent = PdfReportCardHtmlTemplate.GetHTMLString(classReport, selectedClass, session, classSubjects),
//                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = pdfStyleSheetPath },
//                //HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]" },
//                //FooterSettings = { FontName = "Arial", FontSize = 7, Line = true, Left = "Confidence Cooperative Ltd.", Center = "Statement of Account", Right = DateTime.Now.Date.ToShortDateString() }
//            };
//        }
//    }
//}
