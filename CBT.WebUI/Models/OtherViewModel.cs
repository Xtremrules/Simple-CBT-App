using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CBT.WebUI.Models
{
    public class OtherViewModel
    {
        [Required]
        public int OtherID { get; set; }
        [Required]
        public string Content { get; set; }
    }
}