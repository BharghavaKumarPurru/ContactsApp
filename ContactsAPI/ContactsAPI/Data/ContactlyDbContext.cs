using ContactsAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactlyDbContext : DbContext
    {
        public ContactlyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
