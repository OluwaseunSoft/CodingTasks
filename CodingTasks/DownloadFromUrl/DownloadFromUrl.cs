using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.DownloadFromUrl
{
    public class DownloadFromUrl
    {
        public static void SaveContentFromUrl()
        {
            try
            {
                string url = "https://downloadfreeimages.jpg";
                string savePath = @"C:\Users\akinw\source\repos\CodingTasks\CodingTasks\bin\Debug\net6.0\convertedPDF.pdf";
                WebClient web = new WebClient();
                web.DownloadFile(url, savePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
