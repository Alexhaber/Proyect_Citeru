using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Structure.Context
{
    public class CiteruContext : DbContext
    {
        public CiteruContext(DbContextOptions<CiteruContext> opt) : base(opt)
        { }

        public virtual DbSet<Evento> Eventos { get; set; }
    }
}
