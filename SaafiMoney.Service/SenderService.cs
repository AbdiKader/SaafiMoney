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

        public Task Delete(int senderId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Sender> GetAll()
        {
            return _context.Senders
                .Include(sender => sender.Recipients);
        }

        public Sender GetById(int id)
        {
            var sender = _context.Senders
                .Where(s => s.ID == id).Include(s => s.Recipients)
                .FirstOrDefault();
            return sender;
        }

        public Task UpdateAddress(int senderId, string newAddress)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCity(int senderId, string newCity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateIdImageUrl(int senderId, string newIdImageUrl)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePhone(int senderId, string newPhone)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateState(int senderId, string newState)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateZip(int senderId, int newZip)
        {
            throw new System.NotImplementedException();
        }
    }
}
