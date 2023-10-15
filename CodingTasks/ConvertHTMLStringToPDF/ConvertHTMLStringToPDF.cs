using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.HtmlConverter;
using Spire.Pdf.HtmlConverter.Qt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.ConvertHTMLStringToPDF
{
    public class ConvertHTMLStringToPDF
    {
        public static string ConvertHTML2PDF(string pathToHTML)
        {
            try
            {
                //string testHtmlFile = "test12.html";
                string filePath = Path.GetFullPath(pathToHTML);
                string htmlString = File.ReadAllText(filePath);

                string fileName = "convertedPDF.pdf";

                string pluginPath = @"C:\Users\akinw\source\repos\CodingTasks\plugins";

                HtmlConverter.PluginPath = pluginPath;

                HtmlConverter.Convert(htmlString, fileName, true, 1000000, new Size(1080, 1000), new PdfMargins(0), LoadHtmlType.SourceCode);
                return Path.GetFullPath(fileName);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }
    }
}
