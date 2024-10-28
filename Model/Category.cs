using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        // Навигационное свойство, если нужно получить информацию о пользователе этой категории
        public User User { get; set; }
    }

}
