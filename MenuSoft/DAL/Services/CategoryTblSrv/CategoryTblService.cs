using NewMenuSoft.DAL.Models;
using NewMenuSoft.Helper;
using NewMenuSoft.Helper.Enum;
using NewMenuSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL.Services.CategoryTblSrv
{
    class CategoryTblService : ICategoryTblService
    {
        public IEnumerable<Models.CategoryTbl> GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                return unitOfWork.CategoryTbl.GetAll();
            }
        }

        public NewMenuSoft.Models.ResponseModel Create(Models.CategoryTbl category)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                unitOfWork.CategoryTbl.Create(category);
                try
                {
                    return new NewMenuSoft.Models.ResponseModel
                    {
                        Status = NewMenuSoft.Helper.Enum.ResponseMessage.Success
                    };
                }
                catch(Exception ex)
                {
                    return new NewMenuSoft.Models.ResponseModel
                    {
                        Status = NewMenuSoft.Helper.Enum.ResponseMessage.Fail,
                        Message = ex.Message
                    };
                }
            }
        }

        public ResponseModel UpDate(Models.CategoryTbl category)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                unitOfWork.CategoryTbl.Update(category);
                try
                {
                    unitOfWork.SaveChanges();
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Success
                    };
                }
                catch (Exception ex)
                {
                    throw ex;
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Fail,
                        Message = ex.Message
                    };
                }
            }
        }

        public NewMenuSoft.Models.ResponseModel Delete(Models.CategoryTbl category)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                unitOfWork.CategoryTbl.Delete(category);
                try
                {
                    unitOfWork.SaveChanges();
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Success
                    };
                }
                catch (Exception ex)
                {
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Fail,
                        Message = ex.Message
                    };
                }
            }
        }

        public Models.CategoryTbl FindCategoryById(int _id)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                var result = unitOfWork.CategoryTbl.Find(c => c._ID == _id);
                return result != null ? result.FirstOrDefault() : null;
            }
        }

        public Models.CategoryTbl FindCategory(int TenpoCode, int Category_Kubun, int Category_Code)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                Expression<Func<CategoryTbl, bool>> predicate = PredicateBuilder.True<CategoryTbl>();
                predicate = predicate.And(c => c.Category_Code == Category_Code);
                predicate = predicate.And(c => c.Category_Kubun == Category_Kubun);
                predicate = predicate.And(c => c.TenpoCode == TenpoCode);
                var result = GetAll().ToList().Where(predicate.Compile());
                return result != null ? result.SingleOrDefault() : null;
            }
        }
    }
}
