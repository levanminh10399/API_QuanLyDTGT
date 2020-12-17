using Doan_QLHTGT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doan_QLHTGT.Repository
{
    public class XeRepository
    {
        public IEnumerable<Xe> findAll()
        {
            using (var context = new Context())
            {
                return context.Xes.ToList();
            }
        }
        public Xe findById(int id)
        {
            Xe xe = null;
            using (var context = new Context())
            {
                xe = context.Xes.Where(n => n.Id == id).FirstOrDefault<Xe>();
            }
            return xe;
        }
        public void add(Xe xe)
        {
            using (var context = new Context())
            {
                context.Xes.Add(xe);
                context.SaveChanges();
            }
        }
    }
}