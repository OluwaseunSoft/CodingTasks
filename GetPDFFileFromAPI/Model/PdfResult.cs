using System.Net;
using System.Web.Http;

namespace GetPDFFileFromAPI.Model
{
    public class PdfResult : IHttpActionResult
    {
        private readonly MemoryStream PdfStuff;
        private readonly string PdfFileName;
        private readonly HttpRequestMessage httpRequestMessage;
        private HttpResponseMessage httpResponseMessage;

        public PdfResult(MemoryStream data, HttpRequestMessage request, string filename)
        {
            PdfStuff = data;
            httpRequestMessage = request;
            PdfFileName = filename;
        }
        public System.Threading.Tasks.Task<HttpResponseMessage> ExecuteAsync(System.Threading.CancellationToken cancellationToken)
        {
            httpResponseMessage = httpRequestMessage.CreateResponse(HttpStatusCode.OK);
            httpResponseMessage.Content = new StreamContent(PdfStuff);
            //httpResponseMessage.Content = new ByteArrayContent(PdfStuff.ToArray());
            httpResponseMessage.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            httpResponseMessage.Content.Headers.ContentDisposition.FileName = PdfFileName;
            httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream"); // application/pdf
            return System.Threading.Tasks.Task.FromResult(httpResponseMessage);
        }
    }
}
