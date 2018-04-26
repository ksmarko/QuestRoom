using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using SimpleWebApi2.Ninject.Business;
using SimpleWebApi2.Ninject.Models;

namespace SimpleWebApi2.Ninject.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IQuestService questService;
        public ValuesController(IQuestService questService)
        {
            this.questService = questService;
        }

        public IEnumerable<Quest> GetQuests()
        {
            return Mapper.Map<IEnumerable<QuestDTO>, IEnumerable<Quest>>(questService.GetAll());
        }

        public Quest Get(int id)
        {
            return Mapper.Map<QuestDTO, Quest>(questService.Find(id));
        }

        public IEnumerable<Quest> Get(int? players, int? duration, int? price)
        {
            IEnumerable<QuestDTO> quests = questService.GetAll();
            if (players != null)
            {
                quests = quests.Where(x => x.PlayersLimit <= players);
            }
            if (duration != null)
            {
                quests = quests.Where(x => x.Duration <= duration);
            }
            if (price != null)
            {
                quests = quests.Where(x => x.Price <= price);
            }

            //QuestsListViewModel result = new QuestsListViewModel
            //{
            //    Quests = quests.ToList(),
            //    Players = new SelectList(questService.GetAll().Select(x => x.PlayersLimit).Distinct().ToList()),
            //    Duration = new SelectList(questService.GetAll().Select(x => x.Duration).Distinct().ToList()),
            //    Price = new SelectList(questService.GetAll().Select(x => x.Price).Distinct().Where(x => x % 100 == 0).ToList())
            //};

            //return View(result);
            return Mapper.Map<IEnumerable<QuestDTO>, IEnumerable<Quest>>(quests);
        }
    }
}
