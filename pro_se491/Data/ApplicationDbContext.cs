using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pro_se491.Data.Entities;

namespace pro_se491.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Author> Authorities { get; set; } = default;
        public DbSet<Book> Books { get; set; } = default;
    }
}
