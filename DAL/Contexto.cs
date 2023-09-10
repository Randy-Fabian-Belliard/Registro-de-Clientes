using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Clientes> clientes { get; set; }
    
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }
}

