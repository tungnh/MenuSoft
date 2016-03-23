using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL.Repositories.CategoryRps
{
    class CategoryTblRepository : Repository<Models.CategoryTbl>, ICategoryTblRepository
    {
        public MenuSoftDbContext  DbContext
        {
            get { return Context as MenuSoftDbContext; }
        }

        #region Contructor
        public CategoryTblRepository(MenuSoftDbContext context)
            : base(context)
        {
        }

        #endregion
    }
}
