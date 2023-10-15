using CodingTasks.ConvertHTMLStringToPDF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GetPDFFileFromAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("DownloadPdfFile")]
        public async Task<IActionResult> DownloadPdfFile()
        {
            string reqBook = "oluwaseun.pdf";
            string filePath = Path.GetFullPath(reqBook);
            var pathToHtml = ConvertHTMLStringToPDF.ConvertHTML2PDF();
            HttpResponseMessage responseMsg = new HttpResponseMessage(HttpStatusCode.OK);
            responseMsg.Content = new StreamContent(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            string mimeType = "application/pdf";
            return new FileStreamResult(responseMsg.Content.ReadAsStream(), mimeType)
            {
                FileDownloadName = "FileasStream.pdf"
            };
        }
    }
}
