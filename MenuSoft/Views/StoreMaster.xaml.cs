using NewMenuSoft.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewMenuSoft.Views
{
    /* 
     * ViewModelからの変更通知などの各種イベントを受け取る場合は、PropertyChangedWeakEventListenerや
     * CollectionChangedWeakEventListenerを使うと便利です。独自イベントの場合はLivetWeakEventListenerが使用できます。
     * クローズ時などに、LivetCompositeDisposableに格納した各種イベントリスナをDisposeする事でイベントハンドラの開放が容易に行えます。
     *
     * WeakEventListenerなので明示的に開放せずともメモリリークは起こしませんが、できる限り明示的に開放するようにしましょう。
     */

    /// <summary>
    /// StoreMaster.xaml の相互作用ロジック
    /// </summary>
    public partial class StoreMaster : Window
    {
        private string selectedShop;

        public StoreMaster()
        {
            InitializeComponent();
            StoreMasterViewModel vm = new StoreMasterViewModel();
            DataContext = vm;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            ClearItems();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtShopCode.Text) || string.IsNullOrEmpty(txtShopName.Text))
            {
                MessageBox.Show("店舗コード と　店舗名称は、空にすることはできません");
            }
            else
            {
                MessageBoxResult rs = MessageBox.Show("登録しますか？", "確認", MessageBoxButton.YesNo);
                if (rs == MessageBoxResult.Yes)
                {
                    var viewModel = DataContext as StoreMasterViewModel;
                    if (viewModel != null)
                    {
                        //bool updateFlg = viewModel.CheckExistShop(selectedShop);
                        if (!string.IsNullOrEmpty(selectedShop))
                        {
                            viewModel.UpdateShop(selectedShop);
                            MessageBox.Show("ショップが更新されました");
                        }
                        else
                        {
                            viewModel.CreateShop();
                            MessageBox.Show("新しいお店が正常に追加されました");
                            ClearItems();
                        }
                        viewModel.SelectShop();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rs = MessageBox.Show("削除しますか？", "確認", MessageBoxButton.YesNo);
            if (rs == MessageBoxResult.Yes)
            {
                var viewModel = DataContext as StoreMasterViewModel;
                if (viewModel != null)
                {
                    //bool updateFlg = viewModel.CheckExistShop(selectedShop);
                    if (!string.IsNullOrEmpty(selectedShop))
                    {
                        viewModel.DeleteShop(selectedShop);
                        ClearItems();
                        viewModel.SelectShop();
                    }

                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtShopCode_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape: btnNew_Click(sender, e); break;
                case Key.F1: btnRegister_Click(sender, e); break;
                case Key.F3: btnDelete_Click(sender, e); break;
                case Key.F12: btnClose_Click(sender, e); break;
                case Key.Enter: MoveToNextUIElement(e); break;
            }
        }

        private void ClearItems()
        {
            txtShopCode.Text = string.Empty;
            txtShopName.Text = string.Empty;
            selectedShop = string.Empty;
        }

        private void MoveToNextUIElement(KeyEventArgs e)
        {
            // Creating a FocusNavigationDirection object and setting it to a
            // local field that contains the direction selected.
            FocusNavigationDirection focusDirection = FocusNavigationDirection.Next;

            // MoveFocus takes a TraveralReqest as its argument.
            TraversalRequest request = new TraversalRequest(focusDirection);

            // Gets the element with keyboard focus.
            UIElement elementWithFocus = Keyboard.FocusedElement as UIElement;

            // Change keyboard focus.
            if (elementWithFocus != null)
            {
                if (elementWithFocus.MoveFocus(request)) e.Handled = true;
            }
        }

        private void dgShop_GotFocus(object sender, RoutedEventArgs e)
        {
            var selectedIndex = dgShop.Items.IndexOf(dgShop.CurrentItem);

            if (selectedIndex >= 0 && selectedIndex < dgShop.Items.Count - 1)
            {
                var viewModel = DataContext as StoreMasterViewModel;
                if (viewModel != null)
                {
                    selectedShop = viewModel.Shops[selectedIndex].ShopCode;
                    txtShopCode.Text = selectedShop;
                    txtShopName.Text = viewModel.Shops[selectedIndex].ShopName;
                }
            }
        }
    }
}