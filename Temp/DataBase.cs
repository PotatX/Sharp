using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class DataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Initial Catalog=DataBase");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Pacient> Pacients { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
    }
}
