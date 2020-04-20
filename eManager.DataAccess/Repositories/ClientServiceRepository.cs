using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
    public class ClientServiceRepository : IRepository<ClientServiceDTO>
    {
        private readonly ManagerDbContext _context;
        public ClientServiceRepository(ManagerDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {

            ClientServiceDTO model = _context.InvoiceServices.FirstOrDefault(x => x.Id == id);
            _context.SaveChanges();
        }

        public List<ClientServiceDTO> GetAll()
        {
            return _context.InvoiceServices.ToList();
        }

        public ClientServiceDTO GetById(int id)
        {
            var client = _context.InvoiceServices.SingleOrDefault(x => x.Id == id);
            return client;
        }

        public int Insert(ClientServiceDTO entity)
        {
            _context.InvoiceServices.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(ClientServiceDTO entity)
        {
            var model = _context.InvoiceServices.SingleOrDefault(x => x.Id == entity.Id);
       

            _context.InvoiceServices.Update(model);
            int id = _context.SaveChanges();
            return id;
        }
    }
}
