using SaafiMoney.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaafiMoney.Data
{
    public interface ISender
    {
        Sender GetById(int id);
        IEnumerable<Sender> GetAll();
        

        Task Create(Sender sender);
        Task Delete(int senderId);
        Task UpdateAddress(int senderId, string newAddress);
        Task UpdateCity(int senderId, string newCity);
        Task UpdateState(int senderId, string newState);
        Task UpdateZip(int senderId, int newZip);
        Task UpdatePhone(int senderId, string newPhone);
        Task UpdateIdImageUrl(int senderId, string newIdImageUrl);



    }
}
