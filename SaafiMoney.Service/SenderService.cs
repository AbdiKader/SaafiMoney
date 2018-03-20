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

        public async Task Create(Recipient recipient)
        {
            _context.Add(recipient);
            await _context.SaveChangesAsync();
        }
        public async Task Send(Remittance remittance)
        {
            _context.Add(remittance);
            await _context.SaveChangesAsync();
        }
        public Task Delete(string recipientId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Recipient> GetAll(string id)
        {
            var sender = _context.Senders.Where(s => s.Id == id);
            return _context.Recipients
                .Where(r => r.Sender == sender);
        }
        public IEnumerable<Remittance> GetAllRemittances(string id)
        {
            var sender = _context.Senders.Where(s => s.Id == id);
            return _context.Remittances
                .Where(r => r.Sender == sender);
        }
        public IEnumerable<Sender> GetAll()
        {
            return _context.Senders.Include(s => s.Recipients);
        }
        public IEnumerable<Sender> GetAllRemittances()
        {
            return _context.Senders.Include(s => s.Remittances);
        }

        public Recipient GetById(int id)
        {
            var recipient = _context.Recipients
                .Where(s => s.ID == id)
                .FirstOrDefault();
            return recipient;
        }
        public Remittance GetRemittanceById(int id)
        {
            var remittance = _context.Remittances
                .Where(s => s.ID == id)
                .FirstOrDefault();
            return remittance;
        }

        public Sender GetById(string id)
        {
            return _context.Senders.Where(s => s.Id == id)
                .Include(r => r.Recipients)
                .FirstOrDefault();
        }

        public Sender GetRemittanceById(string id)
        {
            return _context.Senders.Where(s => s.Id == id)
                .Include(r => r.Remittances)
                .FirstOrDefault();
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
