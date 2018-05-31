using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleWebApi2.Ninject.Models
{
    public class ReservModel
    {
        [Required]
        public int QuestId { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        public string Code { get; set; }
    }
}