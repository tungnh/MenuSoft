using Livet;
using NewMenuSoft.DAL.Models;
using NewMenuSoft.DAL.Services.CategoryTblSrv;
using NewMenuSoft.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NewMenuSoft.ViewModels
{
    class CategoryTblViewModel : ViewModel
    {
        public static int fix_tenpo = 1;
        #region Clock変更通知プロパティ
        private string _Clock;

        public string Clock
        {
            get
            { return _Clock; }
            set
            {
                if (_Clock == value)
                    return;
                _Clock = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region Category_Name
        private string _Category_Name;

        public string Category_Name
        {
            get 
            { 
                return _Category_Name; 
            }
            set 
            {
                if (_Category_Name == value)
                    return;
                _Category_Name = value;
                RaisePropertyChanged("CategoryName");
            }
        }
        #endregion

        #region Category_Code
        private string _Category_Code;

        public string Category_Code
        {
            get 
            { 
                return _Category_Code; 
            }
            set 
            {
                if (_Category_Code == value)
                    return;
                _Category_Code = value;
                RaisePropertyChanged("CategoryCode");
            }
        }

        #endregion

        #region Categorys
        private List<CategoryTbl> _Categorys;

        public List<CategoryTbl> Categorys
        {
            get
            {
                return _Categorys;
            }
            set
            {
                _Categorys = value;
                RaisePropertyChanged("Categorys");
            }
        }
        #endregion

        #region SelectedItem
        private CategoryTbl _SelectedItem;

        public CategoryTbl SelectedItem
        {
            get { return _SelectedItem; }
            set 
            { 
                _SelectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }
        #endregion

        public void Initialize()
        {
            LoadForm();
            Loop();
        }

        async Task Loop()
        {
            while (true)
            {
                Clock = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }

        private static ICategoryTblService _categoryTblService = new CategoryTblService();

        private void LoadForm()
        {
            SelectCategory();
        }

        public void SelectCategory()
        {
            Categorys = _categoryTblService.GetAll().Where(c => c.Category_Kubun == 0) .ToList();
        }

        public void UpdateCategory(int categoryCode)
        {
            try
            {
                var categoryInfo = _categoryTblService.FindCategory(fix_tenpo, 0, int.Parse(Category_Code));
                if (categoryInfo != null)
                {
                    categoryInfo.Category_Name = Category_Name;
                    categoryInfo.UpdDateTime = DateTime.Now.ToString("yyyMMdd HHmmss");
                    _categoryTblService.UpDate(categoryInfo);
                }
                else
                {
                    MessageBox.Show("Khong tim thay");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
