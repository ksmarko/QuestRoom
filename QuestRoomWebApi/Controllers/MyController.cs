using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuestRoomWebApi.Controllers
{
    public class MyController : ApiController
    {
        IQuestService questService;
        IReservationService reservationService;

        public MyController(IQuestService qService, IReservationService rService)
        {
            questService = qService;
            reservationService = rService;
        }

        // GET api/my
        public IEnumerable<string> GetQuests()
        {
            List<string> list = new List<string>();
            var quests = questService.GetAll();

            foreach (var quest in quests)
                list.Add(quest.Name);

            return list;
        }
    }
}
