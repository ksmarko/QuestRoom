using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Reserv
    {
        public int Id { get; set; }
        public virtual Quest Quest { get; set; }
        public string DateTimeSection { get; set; }
        public double Cost { get; set; }
    }
}
