using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        // Навигационные свойства для получения информации о пользователе и категории продукта
        public User User { get; set; }
        public Category Category { get; set; }
    }

}
