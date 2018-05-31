using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReservationService : IReservationService
    {
        IUnitOfWork Database { get; set; }

        public ReservationService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<string> GetTimeSections(QuestDTO quest, DateTime date)
        {
            List<string> list = new List<string>();
            List<string> exTime = new List<string>();

            int startTime = 8;
            int endTime = 20;

            for (int i = startTime; i < endTime; i += quest.Duration)
            {
                string time = DateTime.Parse(i + ":00").ToShortTimeString();
                string newDateTimeSection = date.ToShortDateString() + " " + time;
                var find = Database.Reserves.Find(x => x.Quest.Id == quest.Id).
                    Intersect(Database.Reserves.Find(x => x.DateTimeSection == newDateTimeSection));

                if (find != null)
                    foreach (var el in find)
                        exTime.Add(el.DateTimeSection.Split(' ')[1]);

                list.Add(time);
            }

            return list.Except(exTime);
        }

        public IEnumerable<ReservDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<Reserv>, List<ReservDTO>>(Database.Reserves.GetAll());
        }

        public void Add(ReservDTO entity)
        {
            if (entity == null || entity.Quest == null)
                throw new ArgumentNullException();

            Database.Reserves.Create(new Reserv
            {
                Quest = Database.Quests.Get(entity.Quest.Id),
                DateTimeSection = entity.DateTimeSections,
                Cost = entity.Cost
            });

            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public bool VerifyCertificateCode(string code)
        {
            List<string> codes = new List<string>
            {
                "QWERTY",
                "DFHDSE",
                "Q6N8DF",
                "FF7KK0",
                "ANNNNA"
            };

            return codes.Contains(code.ToUpper()) ? true : false;
        }
    }
}
