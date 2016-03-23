using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;
using System.Collections.ObjectModel;

using NewMenuSoft.Models;
using NewMenuSoft.DAL.Services.StoreMaster;
using NewMenuSoft.DAL.Models;
using System.Windows;

namespace NewMenuSoft.ViewModels
{

    public class StoreMasterViewModel : ViewModel
    {
        /* コマンド、プロパティの定義にはそれぞれ 
         * 
         *  lvcom   : ViewModelCommand
         *  lvcomn  : ViewModelCommand(CanExecute無)
         *  llcom   : ListenerCommand(パラメータ有のコマンド)
         *  llcomn  : ListenerCommand(パラメータ有のコマンド・CanExecute無)
         *  lprop   : 変更通知プロパティ(.NET4.5ではlpropn)
         *  
         * を使用してください。
         * 
         * Modelが十分にリッチであるならコマンドにこだわる必要はありません。
         * View側のコードビハインドを使用しないMVVMパターンの実装を行う場合でも、ViewModelにメソッドを定義し、
         * LivetCallMethodActionなどから直接メソッドを呼び出してください。
         * 
         * ViewModelのコマンドを呼び出せるLivetのすべてのビヘイビア・トリガー・アクションは
         * 同様に直接ViewModelのメソッドを呼び出し可能です。
         */

        /* ViewModelからViewを操作したい場合は、View側のコードビハインド無で処理を行いたい場合は
         * Messengerプロパティからメッセージ(各種InteractionMessage)を発信する事を検討してください。
         */

        /* Modelからの変更通知などの各種イベントを受け取る場合は、PropertyChangedEventListenerや
         * CollectionChangedEventListenerを使うと便利です。各種ListenerはViewModelに定義されている
         * CompositeDisposableプロパティ(LivetCompositeDisposable型)に格納しておく事でイベント解放を容易に行えます。
         * 
         * ReactiveExtensionsなどを併用する場合は、ReactiveExtensionsのCompositeDisposableを
         * ViewModelのCompositeDisposableプロパティに格納しておくのを推奨します。
         * 
         * LivetのWindowテンプレートではViewのウィンドウが閉じる際にDataContextDisposeActionが動作するようになっており、
         * ViewModelのDisposeが呼ばれCompositeDisposableプロパティに格納されたすべてのIDisposable型のインスタンスが解放されます。
         * 
         * ViewModelを使いまわしたい時などは、ViewからDataContextDisposeActionを取り除くか、発動のタイミングをずらす事で対応可能です。
         */

        /* UIDispatcherを操作する場合は、DispatcherHelperのメソッドを操作してください。
         * UIDispatcher自体はApp.xaml.csでインスタンスを確保してあります。
         * 
         * LivetのViewModelではプロパティ変更通知(RaisePropertyChanged)やDispatcherCollectionを使ったコレクション変更通知は
         * 自動的にUIDispatcher上での通知に変換されます。変更通知に際してUIDispatcherを操作する必要はありません。
         */

        #region StoreMasterModels変更通知プロパティ
        private ObservableCollection<StoreMasterModel>  _StoreMasterModels;

        public ObservableCollection<StoreMasterModel> StoreMasterModels
        {
            get
            { return _StoreMasterModels; }
            set
            { 
                if (_StoreMasterModels == value)
                    return;
                _StoreMasterModels = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region ShopCode変更通知プロパティ
        private string _ShopCode;

        public string ShopCode
        {
            get
            { return _ShopCode; }
            set
            {
                if (_ShopCode == value)
                    return;
                _ShopCode = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region ShopName変更通知プロパティ
        private string _ShopName;

        public string ShopName
        {
            get
            { return _ShopName; }
            set
            {
                if (_ShopName == value)
                    return;
                _ShopName = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region List<TblShop>変更通知プロパティ
        private List<TblShop> _shops;
        public List<TblShop> Shops
        {
            get
            {
                return _shops;
            }
            set
            {
                _shops = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public void Initialize()
        {
            LoadForm();
        }

        private static IStoreMasterService _storeMasterService = new StoreMasterService();
        //TblShop Shops = new TblShop();

        private void LoadForm()
        {
            StoreMasterModels = new ObservableCollection<StoreMasterModel >();
            //_storeMasterService = new StoreMasterService();
            //Shops = _storeMasterService.SelectShop();
            SelectShop();
        }

        public void SelectShop()
        {
            Shops = _storeMasterService.GetAll().ToList();
        }

        public void CreateShop()
        {

            try
            {
                TblShop shop = new TblShop();
                shop.ShopCode = ShopCode;
                shop.ShopName = ShopName;
                shop.ShopStatus = 0;
                shop.CreateDateTime = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                shop.CreateUserID = "";
                shop.UpdateDateTime = null;
                shop.UpdateUserID = null;

                _storeMasterService.Create(shop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void UpdateShop(string shopCode)
        {
            try
            {
                TblShop shop = new TblShop();
                shop = _storeMasterService.FindShop(shopCode);
                shop.ShopCode = ShopCode;
                shop.ShopName = ShopName;
                shop.UpdateDateTime = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                shop.UpdateUserID = "";
                _storeMasterService.UpDate(shop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteShop(string shopCode)
        {
            try
            {
                TblShop shop = new TblShop();
                shop = _storeMasterService.FindShop(shopCode);
                _storeMasterService.Delete(shop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
