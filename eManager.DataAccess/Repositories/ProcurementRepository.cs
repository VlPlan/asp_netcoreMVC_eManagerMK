using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess.Repositories
{
    public class ProcurementRepository:IRepository<Procurement>
    {
        private readonly ManagerDbContext _context;
        public ProcurementRepository(ManagerDbContext context)
        {
            _context = context;
        }
        public void DeleteById(int id)
        {
            Procurement procurement = _context.Procurements.FirstOrDefault(x => x.Id == id);
            if (procurement != null)
            _context.Procurements.Remove(procurement);
            _context.SaveChanges();
        }

        public List<Procurement> GetAll()
        {
            return _context.Procurements.Include(x=>x.ProcurementProducts).ThenInclude(x=>x.Product).Include(u=>u.User).ToList();
        }

        public Procurement GetById(int id)
        {
            var procurement = _context.Procurements.Include(p => p.ProcurementProducts).ThenInclude(x => x.Product).Include(u=>u.User).LastOrDefault(p=>p.Id==id);
            return procurement;
        }

        public int Insert(Procurement entity)
        {
            _context.Procurements.Add(entity);
            return _context.SaveChanges();

        }

        public int Update(Procurement entity)

        {



            _context.Procurements.Update(entity);
            int id = _context.SaveChanges();
            return id;

        }
    }
}
