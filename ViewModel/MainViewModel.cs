using SP_Nurkeldi_Baktybay.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public UserViewModel UserViewModel { get; }
        public CategoryViewModel CategoryViewModel { get; }
        public ProductViewModel ProductViewModel { get; }

        public MainViewModel()
        {
            var userRepository = new UserRepository();
            var categoryRepository = new CategoryRepository();
            var productRepository = new ProductRepository();

            UserViewModel = new UserViewModel(userRepository);
            CategoryViewModel = new CategoryViewModel(categoryRepository, 1); // Примерный userId
            ProductViewModel = new ProductViewModel(productRepository, 1);    // Примерный categoryId
        }
    }

}
