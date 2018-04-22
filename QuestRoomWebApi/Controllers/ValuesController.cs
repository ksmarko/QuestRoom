using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using QuestRoomWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuestRoomWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        IQuestService questService;
        IReservationService reservationService;

        public ValuesController(IQuestService qService, IReservationService rService)
        {
            questService = qService;
            reservationService = rService;
        }

        //GET api/values
        public IEnumerable<string> GetQuests()
        {
            List<string> list = new List<string>();
            var quests = questService.GetAll();

            foreach (var quest in quests)
                list.Add(quest.Name);

            return list;
        }

        //GET api/values/5
        public QuestModel Get(int id)
        {
            return Mapper.Map<QuestDTO, QuestModel>(questService.Find(id));
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
