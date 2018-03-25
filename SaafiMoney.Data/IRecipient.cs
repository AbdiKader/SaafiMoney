using SaafiMoney.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaafiMoney.Data
{
    public interface IRecipient
    {
        Recipient GetById(int id);
        //IEnumerable<Recipient> GetAll(int id);
        IEnumerable<Recipient> GetAll();
        Task Add(Recipient recipient);
        Task Delete(int id);
        Task UpdateFirstName(int id, string newFirstName);
        Task UpdateLastName(int id, string newLastName);
        Task UpdateLocation(int id, string newLocation);
        Task UpdatePhone(int id, string newPhone);
    }
}
