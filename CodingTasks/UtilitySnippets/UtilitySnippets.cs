using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.UtilitySnippets
{
    internal class UtilitySnippets
    {
        public static void TestM()
        {            
            Console.WriteLine(DateTimeProp.StartDate);
        }
    }

    public static class DateTimeProp
    {
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public static string? StartDate { get; set; }
    }
}
