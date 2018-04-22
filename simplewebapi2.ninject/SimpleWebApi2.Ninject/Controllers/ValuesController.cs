using System.Linq;
using System.Web.Http;
using BLL.Interfaces;
using SimpleWebApi2.Ninject.Business;

namespace SimpleWebApi2.Ninject.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IQuestService qs;
        public ValuesController(IQuestService questService)
        {
            qs = questService;
        }

        public int Get()
        {
            return qs.GetAll().Count();
        }
    }
}
