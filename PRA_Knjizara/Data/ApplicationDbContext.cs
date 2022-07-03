using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRA_Knjizara.Models.Authentication;
using PRA_Knjizara.Models.Books;
using PRA_Knjizara.Models.Transactions;

namespace PRA_Knjizara.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<PRA_Knjizara.Models.Transactions.Purchase>? Purchase { get; set; }
    }
}