using SP_Nurkeldi_Baktybay.DataBase;
using SP_Nurkeldi_Baktybay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private readonly UserRepository _userRepository;
        public User CurrentUser { get; private set; }

        public UserViewModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void LoadUser(int userId)
        {
            CurrentUser = _userRepository.GetUserById(userId);
            OnPropertyChanged(nameof(CurrentUser));
        }
    }

}
