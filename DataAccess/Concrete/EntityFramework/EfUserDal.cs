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
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return context.Set<User>().FirstOrDefault(filter);
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return filter == null ? context.Set<User>().ToList() : context.Set<User>().Where(filter).ToList();
            }
        }

        public void Update(User entity)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public User Find(string username, string password)
        {
            using (IsgsDbContext context = new IsgsDbContext())
            {
                return context.Set<User>().Where(x => x.Username == username && x.Password == password).SingleOrDefault();

            }
        }
    }
}
