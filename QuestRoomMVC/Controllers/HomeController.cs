using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using BLL.DTO;
using AutoMapper;
using QuestRoomMVC.Models;
using QuestRoomMVC.Util;

namespace QuestRoomMVC.Controllers
{
    public class HomeController : Controller
    {
        IQuestService questService;
        IReservationService reservationService;

        public HomeController(IQuestService qService, IReservationService rService)
        {
            questService = qService;
            reservationService = rService;
        }

        public ActionResult Index(int? players, int? duration, int? price)
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

            QuestsListViewModel result = new QuestsListViewModel
            {
                Quests = quests.ToList(),
                Players = new SelectList(questService.GetAll().Select(x => x.PlayersLimit).Distinct().ToList()),
                Duration = new SelectList(questService.GetAll().Select(x => x.Duration).Distinct().ToList()),
                Price = new SelectList(questService.GetAll().Select(x => x.Price).Distinct().Where(x => x % 100 == 0).ToList())
            };
            return View(result);
        }

        public ActionResult Info(int id)
        {
            var quest = Mapper.Map<QuestDTO, QuestModel>(questService.Find(id));
            ViewBag.Id = quest.Id;
            return PartialView("QuestView", quest);
        }
    }
}