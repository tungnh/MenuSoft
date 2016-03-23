using NewMenuSoft.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewMenuSoft.Views.Category
{
    /// <summary>
    /// Interaction logic for CategoryTbl.xaml
    /// </summary>
    public partial class CategoryTbl001 : Window
    {
        public CategoryTbl001()
        {
            InitializeComponent();
            CategoryTblViewModel vm = new CategoryTblViewModel();
            DataContext = vm;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var categoryCode = txtCategoryCode.Text;
            var categoryName = txtCategoryName.Text;
            if (string.IsNullOrEmpty(categoryCode) || string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Không để trống");
            }
            else
            {
                MessageBoxResult rs = MessageBox.Show("登録しますか？", "確認", MessageBoxButton.YesNo);
                if (rs == MessageBoxResult.Yes)
                {
                    var viewModel = DataContext as CategoryTblViewModel;
                    if (viewModel != null)
                    {
                        viewModel.UpdateCategory(int.Parse(categoryCode));
                        MessageBox.Show("Cap nhat thanh cong");
                    }
                    viewModel.SelectCategory();
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgCategory_GotFocus(object sender, RoutedEventArgs e)
        {
            var selectedIndex = dgCategory.Items.IndexOf(dgCategory.CurrentItem);
            if (selectedIndex > -1 && selectedIndex < dgCategory.Items.Count)
            {
                var categoryViewModel = DataContext as CategoryTblViewModel;
                txtCategoryCode.Text = categoryViewModel.Categorys[selectedIndex].Category_Code.ToString();
                txtCategoryName.Text = categoryViewModel.Categorys[selectedIndex].Category_Name;
            }
        }
        public void clearItems()
        {
            txtCategoryCode.Text = "";
            txtCategoryName.Text = "";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1: btnRegister_Click(sender, e); break;
                case Key.F12: btnClose_Click(sender, e); break;
            }
        }

    }
}
