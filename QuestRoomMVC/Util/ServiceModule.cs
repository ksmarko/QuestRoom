using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRoomMVC.Util
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IReservationService>().To<ReservationService>();
            Bind<IQuestService>().To<QuestService>();
        }
    }
}