using SP_Nurkeldi_Baktybay.DataBase;
using SP_Nurkeldi_Baktybay.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.ViewModel
{
    public class CategoryViewModel : ViewModelBase
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly int _userId;
        public ObservableCollection<Category> Categories { get; private set; }

        public CategoryViewModel(CategoryRepository categoryRepository, int userId)
        {
            _categoryRepository = categoryRepository;
            _userId = userId;
            LoadCategories();
        }

        private void LoadCategories()
        {
            Categories = new ObservableCollection<Category>(_categoryRepository.GetCategoriesByUserId(_userId));
            OnPropertyChanged(nameof(Categories));
        }
    }

}
