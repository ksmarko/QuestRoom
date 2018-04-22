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
    }
}
