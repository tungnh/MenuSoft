namespace NewMenuSoft.DAL
{
    using NewMenuSoft.DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class MenuSortDbContext : DbContext
    {
        public MenuSortDbContext()
            : base("name=MenuSortDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<TblShop> TblShop { get; set; }

    }
}
