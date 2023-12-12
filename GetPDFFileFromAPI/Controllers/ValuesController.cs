using CodingTasks.ConvertHTMLStringToPDF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;

namespace GetPDFFileFromAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("ToDownloadPdfFile")]
        public async Task<IActionResult> DownloadPdfFile()
        {
            try
            {
                string reqBook = "wwwroot\\test12.html";
                var pathToHtml = ConvertHTMLStringToPDF.ConvertHTML2PDF(Path.GetFullPath(reqBook));
                var t = AppDomain.CurrentDomain.BaseDirectory + pathToHtml;
                var u = CopyFile.CopyFileToDirectory(t);
                string filePath = Path.GetFullPath(u);
                HttpResponseMessage responseMsg = new HttpResponseMessage(HttpStatusCode.OK);
                responseMsg.Content = new StreamContent(new FileStream(filePath, FileMode.Open, FileAccess.Read));
                string mimeType = "application/pdf";
                return new FileStreamResult(responseMsg.Content.ReadAsStream(), mimeType)
                {
                    FileDownloadName = "newfile.pdf"
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new NotFoundResult();
            }
        }

        [HttpGet("F1")]
        public async Task<FileContentResult> GetFile()
        {
            string localFilePath = "wwwroot\\296convertedPDF.pdf";
            string filePath = Path.GetFullPath(localFilePath);
            var bytes = await System.IO.File.ReadAllBytesAsync(filePath).ConfigureAwait(false);
            return File(bytes, "application/pdf", Path.GetFileName(filePath));
        }

        [HttpGet("F2")]
        public async Task<PhysicalFileResult> GetFilePhysicalPath()
        {
            string localFilePath = "wwwroot\\296convertedPDF.pdf";
            string filePath = Path.GetFullPath(localFilePath);
            var bytes = await System.IO.File.ReadAllBytesAsync(filePath).ConfigureAwait(false);
            return new PhysicalFileResult(filePath, "application/pdf");
        }

        [HttpGet("F3")]
        public async Task<FileResult> GetFileVirtual()
        {
            try
            {
                return new VirtualFileResult("/Files/convertedPDF.pdf", "application/pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }

        [HttpGet("F4")]
        public async Task<FileResult> GetFileVirtual()
        {
            try
            {
                return new VirtualFileResult("/Files/convertedPDF.pdf", "application/pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }
    }
}
