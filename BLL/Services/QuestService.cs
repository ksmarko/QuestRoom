using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class QuestService : IQuestService
    {
        IUnitOfWork Database { get; set; }

        public QuestService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public QuestDTO Find(int id)
        {
            return Mapper.Map<Quest, QuestDTO>(Database.Quests.Get(id));
        }

        public IEnumerable<QuestDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<Quest>, List<QuestDTO>>(Database.Quests.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<QuestDTO> Find(Func<QuestDTO, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<QuestDTO> FilterResults(int players, int duration, int price)
        {
            IEnumerable<QuestDTO> quests = GetAll();
                quests = quests.Where(x => x.PlayersLimit <= players);
                quests = quests.Where(x => x.Price <= price);
            quests = quests.Where(x => x.Duration <= duration);


            return quests;
        }
    }
}
