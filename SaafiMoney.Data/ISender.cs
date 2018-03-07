using SaafiMoney.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaafiMoney.Data
{
    public interface ISender
    {
        Sender GetById(string id);
        IEnumerable<Sender> GetAll();
        

        Task Create(Sender sender);
        Task Delete(string senderId);
        Task UpdateAddress(string senderAddress, string newAddress);
        Task UpdateCity(string senderCity, string newCity);
        Task UpdateState(string senderState, string newState);
        Task UpdateZip(int senderZip, int newZip);
        Task UpdatePhone(string senderPhone, string newPhone);
        Task UpdateIdImageUrl(string senderImageUrl, string newIdImageUrl);



    }
}
