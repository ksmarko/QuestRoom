using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebApi2.Ninject.Models
{
    public class QuestsListViewModel
    {
        public IEnumerable<QuestDTO> Quests { get; set; }
        public string Description { get; set; }
        public SelectList Players { get; set; }
        public SelectList Duration { get; set; }
        public SelectList Price { get; set; }
    }
}