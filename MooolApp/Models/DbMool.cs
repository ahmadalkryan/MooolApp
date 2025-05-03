using Microsoft.EntityFrameworkCore;

namespace MooolApp.Models
{
    public class DbMool : DbContext
    {
        public DbMool(DbContextOptions<DbMool> op) : base(op)
        {

        }

        public virtual DbSet<Mool> Mool { get; set; }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Address> Addressess { get; set; }


        




    }
}
