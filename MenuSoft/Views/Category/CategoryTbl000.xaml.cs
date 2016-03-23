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
    /// Interaction logic for CategoryTbl000.xaml
    /// </summary>
    public partial class CategoryTbl000 : Window
    {
        public CategoryTbl000()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F12:
                    this.Close();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CategoryTbl001 view = new CategoryTbl001();
            view.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
