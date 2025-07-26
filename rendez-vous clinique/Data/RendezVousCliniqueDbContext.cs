using Microsoft.EntityFrameworkCore;

namespace rendezVousClinique.Data;

public class RendezVousCliniqueDbContext : DbContext
{
    public RendezVousCliniqueDbContext(DbContextOptions­<RendezVousCliniqueDbContext> options) : base(options) 
    {
    }
}


