using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiLogging.Models
{
    public class Log
    {
        [Required(ErrorMessage = "Please enter a valid URL")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Please enter a valid IP Address")]
        [RegularExpression("^(?:[0-9]{1,3}\\.){3}[0-9]{1,3}$",
        ErrorMessage = "IP Address not in the correct format")]
        public string IpAddress { get; set; }
        [Required]
        [RegularExpression(@"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$",
            ErrorMessage="Date should be in the format : MM/DD/YYYY")]
        public DateTime Date { get; set; }
    }
}