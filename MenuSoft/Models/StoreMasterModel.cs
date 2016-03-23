using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Livet;
using NewMenuSoft.DAL.Services.StoreMaster;
using NewMenuSoft.DAL.Models;

namespace NewMenuSoft.Models
{
    public class StoreMasterModel : NotificationObject
    {
        /*
         * NotificationObjectはプロパティ変更通知の仕組みを実装したオブジェクトです。
         */
        //#region ShopCode変更通知プロパティ
        //private string _ShopCode;

        //public string ShopCode
        //{
        //    get
        //    { return _ShopCode; }
        //    set
        //    {
        //        if (_ShopCode == value)
        //            return;
        //        _ShopCode = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //#endregion

        //#region ShopName変更通知プロパティ
        //private string _ShopName;

        //public string ShopName
        //{
        //    get
        //    { return _ShopName; }
        //    set
        //    {
        //        if (_ShopName == value)
        //            return;
        //        _ShopName = value;
        //        RaisePropertyChanged();
        //    }
        //}
        //#endregion

        //private static IStoreMasterService _storeMasterService;
        //public static StoreMasterModel ParseToViewModel(TblShop shop)
        //{
        //    return new StoreMasterModel
        //    {
        //        ShopCode = shop.ShopCode ,
        //        ShopName = shop.ShopName
        //    };
        //}

    }
}
