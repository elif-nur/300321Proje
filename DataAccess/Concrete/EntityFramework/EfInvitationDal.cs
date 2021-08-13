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
    public class EfInvitationDal : IInvitationDal
    {
        public void Add(Invitation entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Invitation entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Invitation Get(Expression<Func<Invitation, bool>> filter)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return context.Set<Invitation>().FirstOrDefault(filter);
            }
        }

        public List<Invitation> GetAll(Expression<Func<Invitation, bool>> filter = null)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return filter == null ? context.Set<Invitation>().ToList() : context.Set<Invitation>().Where(filter).ToList();
            }
        }

        public void Update(Invitation entity)
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
