using BLL.Infrastructure;
using Ninject;
using Ninject.Modules;
using QuestRoomApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestRoomApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BLL.Infrastructure.AutoMapperConfig.Initialize();

            //for unit of work binding
            NinjectModule uowModule = new ConnectionModule("DefaultConnection");

            //for quest and reserv services binding
            NinjectModule serviceModule = new ServiceModule();
            
            var kernel = new StandardKernel(uowModule, serviceModule);
            Application.Run(kernel.Get<Form1>());
        }
    }
}
