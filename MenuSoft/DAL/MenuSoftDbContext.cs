namespace NewMenuSoft.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using NewMenuSoft.DAL.Models;

    public partial class MenuSoftDbContext : DbContext
    {
        public MenuSoftDbContext()
            : base("name=MenuSoftDbContext")
        {
        }


        public virtual DbSet<TblShop> TblShops { get; set; }

        public virtual DbSet<CategoryTbl> CategoryTbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblShop>()
                .Property(e => e.ShopID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TblShop>()
                .Property(e => e.ShopCode)
                .IsUnicode(false);

            modelBuilder.Entity<TblShop>()
                .Property(e => e.ShopName)
                .IsUnicode(false);

            modelBuilder.Entity<TblShop>()
                .Property(e => e.CreateDateTime)
                .IsUnicode(false);

            modelBuilder.Entity<TblShop>()
                .Property(e => e.CreateUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TblShop>()
                .Property(e => e.UpdateDateTime)
                .IsUnicode(false);

            modelBuilder.Entity<TblShop>()
                .Property(e => e.UpdateUserID)
                .IsUnicode(false);

           
        }
    }
}
