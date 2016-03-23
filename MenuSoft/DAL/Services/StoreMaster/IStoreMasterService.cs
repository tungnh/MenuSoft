using NewMenuSoft.DAL.Models;
using NewMenuSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL.Services.StoreMaster
{
    public interface IStoreMasterService
    {
        //List<TblShop > SelectShop();
        //TblShop CreateShop();
        //TblShop UpdateShop(string shopCode);
        //TblShop DeleteShop(string shopCode);
        IEnumerable<TblShop> GetAll();
        ResponseModel Create(TblShop shop);
        ResponseModel UpDate(TblShop shop);
        ResponseModel Delete(TblShop shop);
        TblShop FindShop(string shopCode);
    }
}
