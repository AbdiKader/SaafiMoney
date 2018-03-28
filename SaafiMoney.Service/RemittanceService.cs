
using System.Collections.Generic;
using System.Threading.Tasks;
using SaafiMoney.Data;
using SaafiMoney.Data.Models;

namespace SaafiMoney.Service
{
    public class RemittanceService : IRemittance
    {
        private readonly ApplicationDbContext _context;

        public RemittanceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(Remittance remittance)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Remittance> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Remittance GetById(int id)
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
