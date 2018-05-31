using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using SimpleWebApi2.Ninject.Models;

namespace SimpleWebApi2.Ninject.Controllers
{
    public class QuestsController : ApiController
    {
        private readonly IQuestService questService;
        private readonly IReservationService reservationService;

        public QuestsController(IQuestService questService, IReservationService reservationService)
        {
            this.questService = questService;
            this.reservationService = reservationService;
        }

        [HttpGet]
        // GET api/quests
        public IEnumerable<Quest> GetQuests()
        {
            return Mapper.Map<IEnumerable<QuestDTO>, IEnumerable<Quest>>(questService.GetAll());
        }

        [HttpGet]
        // GET api/quests/5
        public Quest Get(int id)
        {
            return Mapper.Map<QuestDTO, Quest>(questService.Find(id));
        }

        [HttpPost]
        [Route("api/quests/reserv")]
        public IHttpActionResult Reserv(ReservModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data");

            var quest = questService.GetAll().Where(x => x.Id == model.QuestId).FirstOrDefault();
            double cost = quest.Price;

            if (!String.IsNullOrEmpty(model.Code))
                if (reservationService.VerifyCertificateCode(model.Code))
                    cost = 0;
                else return BadRequest("Invalid code");

            reservationService.Add(new ReservDTO { Quest = quest, DateTimeSections = model.Date + " " + model.Time, Cost = cost });
            return Ok($"Quest \"{quest.Name}\" reserved for {model.Date} on {model.Time}\nCost: {cost} grn");
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

            return Mapper.Map<IEnumerable<QuestDTO>, IEnumerable<Quest>>(quests);
        }
    }
}
