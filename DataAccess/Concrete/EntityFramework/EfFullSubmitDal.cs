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
    public class EfFullSubmitDal : IFullSubmitDal
    {
        public void Add(FullSubmit entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(FullSubmit entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public FullSubmit Get(Expression<Func<FullSubmit, bool>> filter)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return context.Set<FullSubmit>().FirstOrDefault(filter);
            }
        }

        public List<FullSubmit> GetAll(Expression<Func<FullSubmit, bool>> filter = null)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return filter == null ? context.Set<FullSubmit>().ToList() : context.Set<FullSubmit>().Where(filter).ToList();
            }
        }

        public void Update(FullSubmit entity)
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
