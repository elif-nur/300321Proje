using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class IsgsDbContext : DbContext
    {
        public DbSet<Date> Dates { get; set; }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<FirstPage> FirstPages { get; set; }
        public DbSet<Honorary> Honoraries { get; set; }
        public DbSet<Organising> Organisings { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Scientific> Scientifics { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Solidarity> Solidarities { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<General> Generals { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Secretariat> Secretariats { get; set; }
        public DbSet<Writing> Writings { get; set; }
        public DbSet<Submit> Submits { get; set; }
        public DbSet<FullSubmit> FullSubmits { get; set; }
        public DbSet<Accepted> Accepteds { get; set; }
    }
}
