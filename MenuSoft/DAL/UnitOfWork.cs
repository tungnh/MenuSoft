using NewMenuSoft.DAL;
using NewMenuSoft.DAL.Repositories;
using NewMenuSoft.DAL.Repositories.CategoryRps;
using NewMenuSoft.DAL.Repositories.TblShop;

namespace NewMenuSoft.DAL
{
    public class UnitOfWork:IUnitOfWork 
    {

        private readonly MenuSoftDbContext _context;

        public UnitOfWork (MenuSoftDbContext context)
        {
            _context = context;
            TblShop = new TblShopRepository(_context);
            CategoryTbl = new CategoryTblRepository(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ITblShopRepository TblShop { get; private set; }
        public ICategoryTblRepository CategoryTbl { get; private set; }
    }
}
