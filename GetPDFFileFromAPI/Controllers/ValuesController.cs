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
        [Route("Stream")]
        public async Task<IActionResult> DownloadPdfFile(string id)
        {
            string reqBook = "oluwaseun.pdf";
            string filePath = Path.GetFullPath(reqBook);
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
