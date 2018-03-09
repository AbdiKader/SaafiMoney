﻿using System.Collections.Generic;
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

        public Task Create(Recipient recipient)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string recipientId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Recipient> GetAll(string id)
        {
            var sender = _context.Senders.Where(s => s.Id == id);
            return _context.Recipients;
        }

        public IEnumerable<Sender> GetAll()
        {
            return _context.Senders.Include(s => s.Recipients);
        }

        public Recipient GetById(int id)
        {
            var recipient = _context.Recipients
                .Where(s => s.Id == id)
                .FirstOrDefault();
            return recipient ;
        }

        public Sender GetById(string id)
        {
            return _context.Senders.Where(s => s.Id == id)
                .Include(r => r.Recipients)
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
