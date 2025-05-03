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

            modelBuilder.Entity<Item>(
                o =>
                {
                    o.Property(o => o.Id).ValueGeneratedOnAdd();
                    o.Property(o => o.Name).IsRequired().HasDefaultValue("food");
                    o.Property(o=>o.Description).IsRequired().HasDefaultValue("ver good");
                    o.Property(o => o.price).IsRequired().HasDefaultValue(3456);
             
                    o.HasKey(o => o.Id);
                    o.ToTable("Items");
                    o.HasOne(o => o.Mool).WithMany(b => b.Items).
                    HasForeignKey(m => m.MoolID).OnDelete(DeleteBehavior.Cascade);
                }
         );
            modelBuilder.Entity<Item>().HasData(
                new Item
                {   Id="20",
                    Name = "drink",
                    Description = "ver cool",
                    price = 40000,
                   

                },
                new Item
                {    Id = "21",
                    Name = "drink1",
                    Description = "ver cool2",
                    price = 4000,
                   

                }
                );
            modelBuilder.Entity<Mool>().HasData(
                new Mool
                {
                    Id = "20",
                    Name="qunitra",
                    
                },
                new Mool
                {
                    Id="21",
                    Name="hmra1"
                }
                );


            modelBuilder.Entity<Mool>(
                m =>
                {
                    m.Property(d => d.Id).ValueGeneratedOnAdd();
                    m.Property(d =>d.Name).HasColumnName("NAme").IsRequired();
                    m.ToTable("Mool");
                    m.HasKey(d => d.Id);
                    

                }

                );
            
                






        }
        




    }
}
