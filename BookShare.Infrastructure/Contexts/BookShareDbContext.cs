using BookShare.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Infrastructure.Contexts
{
    public class BookShareDbContext : DbContext
    {
        public BookShareDbContext(DbContextOptions<BookShareDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Anuncio> Anuncio { get; set; }
        public DbSet<Livro> Livro { get; set; }
    }
}
