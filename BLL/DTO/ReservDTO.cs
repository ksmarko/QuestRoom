using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ReservDTO
    {
        public int Id { get; set; }
        public QuestDTO Quest { get; set; }
        public string DateTimeSections { get; set; }
        public double Cost { get; set; }
    }
}
