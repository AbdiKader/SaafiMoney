﻿using SaafiMoney.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaafiMoney.Data
{
    public interface ISender
    {
        Sender GetById(string id);
        Recipient GetById(int id);
        IEnumerable<Recipient> GetAll(string id);
        IEnumerable<Sender> GetAll();
        
        
        Task Create(Recipient recipient);
        Task Delete(string recipientId);
        Task UpdateAddress(string senderAddress, string newAddress);
        Task UpdateCity(string senderCity, string newCity);
        Task UpdateState(string senderState, string newState);
        Task UpdateZip(int senderZip, int newZip);
        Task UpdatePhone(string senderPhone, string newPhone);
        Task UpdateIdImageUrl(string senderImageUrl, string newIdImageUrl);



    }
}
