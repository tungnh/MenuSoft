using NewMenuSoft.DAL.Models;
using NewMenuSoft.Helper.Enum;
using NewMenuSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL.Services.StoreMaster
{
    public class StoreMasterService : IStoreMasterService
    {

        public IEnumerable<TblShop> GetAll()
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                return unitOfWork.TblShop.GetAll();
            }
        }

        public ResponseModel Create(Models.TblShop shop)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {

                unitOfWork.TblShop.Create(shop);
                try
                {
                    unitOfWork.SaveChanges();
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Success
                    };
                }
                catch (Exception exception)
                {
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Fail,
                        Message = exception.Message
                    };
                }
            }
        }

        public ResponseModel UpDate(Models.TblShop shop)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                unitOfWork.TblShop.Update(shop);

                try
                {
                    unitOfWork.SaveChanges();
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Success
                    };
                }
                catch (Exception exception)
                {
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Fail,
                        Message = exception.Message
                    };
                }
            }
        }

        public ResponseModel Delete(Models.TblShop shop)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {

                unitOfWork.TblShop.Delete(shop);
                try
                {
                    unitOfWork.SaveChanges();
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Success
                    };
                }
                catch (Exception exception)
                {
                    return new ResponseModel
                    {
                        Status = ResponseMessage.Fail,
                        Message = exception.Message
                    };
                }
            }
        }

        TblShop IStoreMasterService.FindShop(string shopCode)
        {
            using (var unitOfWork = new UnitOfWork(new MenuSoftDbContext()))
            {
                var result = unitOfWork.TblShop.Find(x => x.ShopCode == shopCode);

                return result != null ? result.FirstOrDefault() : null;
            }
        }
    }


}
