using EFTest.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private TestdbEntities db = null;
        private DbSet<T> table = null;

        public Repository()
        {
            db = new TestdbEntities();
            table = db.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return table.ToList<T>();
        }

        public T SelectByID(int id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T existing = table.Find(id);

        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
