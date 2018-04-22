using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebApi2.Ninject.Models
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public QuestsListViewModel Quest { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}