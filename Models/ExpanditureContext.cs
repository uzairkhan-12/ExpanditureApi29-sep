using Microsoft.EntityFrameworkCore;

namespace ExpanditureApi.Models {
    public class ExpanditureContext : DbContext {
        public ExpanditureContext(DbContextOptions<ExpanditureContext>options) : base(options) { }
        public DbSet<Income> Income {get ; set ;}
    }
}