using SP_Nurkeldi_Baktybay.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.DataBase
{
    public class ProductRepository
    {
        private readonly string _connectionString = "Data Source=database.db";

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            var products = new List<Product>();
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand("SELECT * FROM Products WHERE CategoryId = @categoryId", connection);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    UserId = reader.GetInt32(2),
                    CategoryId = reader.GetInt32(3)
                });
            }
            return products;
        }
    }

}
