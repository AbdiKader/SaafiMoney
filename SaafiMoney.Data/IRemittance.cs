using SaafiMoney.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaafiMoney.Service
{
    public interface IRemittance
    {

        Remittance GetById(int id);
        IEnumerable<Remittance> GetAll();

        Task Add(Remittance recipient);
        Task Delete(int id);
        Task UpdateFirstName(int id, string newFirstName);
        Task UpdateLastName(int id, string newLastName);
        Task UpdateLocation(int id, string newLocation);
        Task UpdatePhone(int id, string newPhone);
    }
}