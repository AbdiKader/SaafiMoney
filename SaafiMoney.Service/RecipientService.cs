using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaafiMoney.Data;
using SaafiMoney.Data.Models;

namespace SaafiMoney.Service
{
    public class RecipientService : IRecipient
    {
        private readonly ApplicationDbContext _context;

        public RecipientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(Recipient recipient)
        {
             _context.Add(recipient);
           return _context.SaveChangesAsync();
            //return recipient;
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        //public IEnumerable<Recipient> GetAll(int id)
        //{
        //    var stringId = id.ToString();
        //    var sender = _context.Senders.Where(r => r.Id == stringId);
        //    return _context.Recipients;
        //}
        public IEnumerable<Recipient> GetAll()
        {
            return _context.Recipients;
        }

        public Recipient GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateFirstName(int id, string newFirstName)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateLastName(int id, string newLastName)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateLocation(int id, string newLocation)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePhone(int id, string newPhone)
        {
            throw new System.NotImplementedException();
        }
    }
}
