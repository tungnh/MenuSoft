using NewMenuSoft.DAL.Models;
using NewMenuSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL.Services.CategoryTblSrv
{
    interface ICategoryTblService
    {
        IEnumerable<CategoryTbl> GetAll();
        ResponseModel Create(CategoryTbl category);
        ResponseModel UpDate(CategoryTbl category);
        ResponseModel Delete(CategoryTbl category);
        CategoryTbl FindCategoryById(int id);
        CategoryTbl FindCategory(int TenpoCode, int Category_Kubun, int Category_Code);
    }
}
