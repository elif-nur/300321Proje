using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWritingDal : IWritingDal
    {
        public void Add(Writing entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Writing entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Writing Get(Expression<Func<Writing, bool>> filter)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return context.Set<Writing>().FirstOrDefault(filter);
            }
        }

        public List<Writing> GetAll(Expression<Func<Writing, bool>> filter = null)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return filter == null ? context.Set<Writing>().ToList() : context.Set<Writing>().Where(filter).ToList();
            }
        }

        public void Update(Writing entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
