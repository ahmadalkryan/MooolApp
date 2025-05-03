using Microsoft.EntityFrameworkCore;

namespace MooolApp.Models
{
    public class DbMool : DbContext
    {
        public DbMool(DbContextOptions<DbMool> op) : base(op)
        {

        }

        public virtual DbSet<Mool> Mools { get; set; }

        public virtual DbSet<Item> Items { get; set; }
        //   public virtual DbSet<Address> Addressess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = "1",
                    Name = "colths",
                    price = 2440,
                    Description ="this is very nice",
                    MoolID = "2",

                }
                );
            modelBuilder.Entity<Mool>().HasData(
                new Mool
                {
                    Id = "2",
                    Name ="kaseon",
                    //Address=new Address { city ="syria" ,street ="hmra"}
                }

                );






        }
        




    }
}
