using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IQuestService
    {
        IEnumerable<QuestDTO> GetAll();
        void Dispose();
        QuestDTO Find(int id);
        IEnumerable<QuestDTO> Find(Func<QuestDTO, Boolean> predicate);
        IEnumerable<QuestDTO> FilterResults(int players, int duration, int price);
    }
}
