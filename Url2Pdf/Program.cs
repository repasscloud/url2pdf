using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using WDSE;

using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.IO.Image;

class Program
{
    static void Main(string[] args)
    {
        // Create subfolder
        string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(uploadPath);

        // Specify the path to the Firefox executable
        string driverPath = Path.Combine(Directory.GetCurrentDirectory(), "geckodriver");

        // Disable logging to stop output
        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
        service.LogLevel = FirefoxDriverLogLevel.Trace;
        service.Start();

        // Create a new FirefoxOptions instance and set any desired options
        FirefoxOptions options = new FirefoxOptions();

        // Make the Firefox headless
        options.AddArgument("--headless");

        // Create a new Firefox instance using the specified path and options
        IWebDriver driver = new FirefoxDriver(options);

        // Navigate to the web page
        driver.Navigate().GoToUrl("https://www.amazon.com/");

        // Wait for the webpage to load
        System.Threading.Thread.Sleep(5000);

        // Use the VerticalCombineDecorator to capture entire page:
        var vcs = new VerticalCombineDecorator(new ScreenshotMaker());
        var screen = driver.TakeScreenshot(vcs);

        // Save JPG of website
        string filePath = Path.Combine(uploadPath, "image.jpg"); // replace with the path to your output file
        File.WriteAllBytes(filePath, screen);

        // Close the browser and end the session
        driver.Quit();

        if (args.Contains("--pdf"))
        {
            // Create PDF output
            CreatePdf(outputPath: uploadPath, imagePath: filePath);
        }
    }

    static void CreatePdf(string outputPath, string imagePath)
    {

        int width;
        int height;

        using (var image = SixLabors.ImageSharp.Image.Load(imagePath))
        {
            width = image.Width;
            height = image.Height;
        }

        iText.Kernel.Geom.Rectangle customPageSize = new iText.Kernel.Geom.Rectangle(width, height);

        string dest = Path.Combine(outputPath, "output.pdf");
        PdfWriter writer = new PdfWriter(dest);

        PdfDocument pdf = new PdfDocument(writer);
        Document document = new Document(pdf, pageSize: new iText.Kernel.Geom.PageSize(customPageSize));

        //// Add header
        //Paragraph header = new Paragraph("HEADER")
        //    .SetTextAlignment(TextAlignment.CENTER)
        //    .SetFontSize(20);
        //document.Add(header);

        //// Add subheader
        //Paragraph subheader = new Paragraph("SUB HEADER")
        //   .SetTextAlignment(TextAlignment.CENTER)
        //   .SetFontSize(15);
        //document.Add(subheader);

        //// Line separator
        //LineSeparator ls = new LineSeparator(new SolidLine());
        //document.Add(ls);

        // Add image
        iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory
           .Create(imagePath))
           .SetTextAlignment(TextAlignment.CENTER);
        document.Add(img);

        document.Close();
    }
}
