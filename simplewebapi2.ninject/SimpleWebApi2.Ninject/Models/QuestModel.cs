using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebApi2.Ninject.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PlayersLimit { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }
    }
}