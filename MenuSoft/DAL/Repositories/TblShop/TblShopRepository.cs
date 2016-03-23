namespace NewMenuSoft.DAL.Repositories.TblShop
{
    public class TblShopRepository: Repository<Models .TblShop>, ITblShopRepository
    {
        public MenuSoftDbContext  DbContext
        {
            get { return Context as MenuSoftDbContext; }
        }

        #region Contructor
        public TblShopRepository(MenuSoftDbContext context)
            : base(context)
        {
        }

        #endregion
    }
}
