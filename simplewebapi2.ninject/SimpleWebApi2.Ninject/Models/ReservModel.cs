using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebApi2.Ninject.Models
{
    public class ReservModel
    {
        public int QuestId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Code { get; set; }
    }
}