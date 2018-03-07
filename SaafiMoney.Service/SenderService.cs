using System.Collections.Generic;
using System.Threading.Tasks;
using SaafiMoney.Data;
using SaafiMoney.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SaafiMoney.Service
{
    public class SenderService : ISender
    {
        private readonly ApplicationDbContext _context;

        public SenderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Sender sender)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string senderId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Sender> GetAll()
        {
            return _context.Senders
                .Include(sender => sender.Recipients);
        }

        public Sender GetById(string id)
        {
            var sender = _context.Senders
                .Where(s => s.Id == id).Include(s => s.Recipients)
                .FirstOrDefault();
            return sender;
        }

        public Task UpdateAddress(string senderAddress, string newAddress)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCity(string senderCity, string newCity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateIdImageUrl(string senderImageUrl, string newIdImageUrl)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePhone(string senderPhone, string newPhone)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateState(string senderState, string newState)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateZip(int senderZip, int newZip)
        {
            throw new System.NotImplementedException();
        }
    }
}
