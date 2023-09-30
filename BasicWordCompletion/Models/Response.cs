using System.ComponentModel.DataAnnotations;

namespace BasicWordCompletion.Models
{
    public class Response
    {
        [Display(Name ="data")]
        public string[] Data { get; set; }
    }
}
