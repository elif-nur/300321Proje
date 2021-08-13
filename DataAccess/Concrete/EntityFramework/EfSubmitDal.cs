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
    public class EfSubmitDal : ISubmitDal
    {
        public void Add(Submit entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Submit entity)
        {

            using (IsgsDbContext context = new IsgsDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Submit Get(Expression<Func<Submit, bool>> filter)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return context.Set<Submit>().FirstOrDefault(filter);
            }
        }

        public List<Submit> GetAll(Expression<Func<Submit, bool>> filter = null)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return filter == null ? context.Set<Submit>().ToList() : context.Set<Submit>().Where(filter).ToList();
            }
        }

        public void Update(Submit entity)
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
