using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IReservationService
    {
        IEnumerable<ReservDTO> GetAll();
        void Add(ReservDTO entity);
        void Dispose();
        IEnumerable<string> GetTimeSections(QuestDTO quest, DateTime date);
        bool VerifyCertificateCode(string code);
    }
}
