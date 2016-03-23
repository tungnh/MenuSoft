using NewMenuSoft.DAL.Repositories.CategoryRps;
using NewMenuSoft.DAL.Repositories.TblShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ITblShopRepository TblShop { get; }
        ICategoryTblRepository CategoryTbl { get; }

        int SaveChanges();
    }
}
