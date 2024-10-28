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
    public class ProductViewModel : ViewModelBase
    {
        private readonly ProductRepository _productRepository;
        private readonly int _categoryId;
        public ObservableCollection<Product> Products { get; private set; }

        public ProductViewModel(ProductRepository productRepository, int categoryId)
        {
            _productRepository = productRepository;
            _categoryId = categoryId;
            LoadProducts();
        }

        private void LoadProducts()
        {
            Products = new ObservableCollection<Product>(_productRepository.GetProductsByCategoryId(_categoryId));
            OnPropertyChanged(nameof(Products));
        }
    }

}
