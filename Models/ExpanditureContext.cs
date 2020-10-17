using Microsoft.EntityFrameworkCore;

namespace ExpanditureApi.Models {
    public class ExpanditureContext : DbContext {
        public ExpanditureContext(DbContextOptions<ExpanditureContext>options) : base(options) { }
        public DbSet<Income> Income {get ; set ;}
        public DbSet<ExpenditureType> ExpenditureTypes {get;set;}
        public DbSet<Expanditure> Expanditures {get;set;}
    }
}