using SP_Nurkeldi_Baktybay.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.DataBase
{
    public class CategoryRepository
    {
        private readonly string _connectionString = "Data Source=database.db";

        public IEnumerable<Category> GetCategoriesByUserId(int userId)
        {
            var categories = new List<Category>();
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand("SELECT * FROM Categories WHERE UserId = @userId", connection);
            command.Parameters.AddWithValue("@userId", userId);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    UserId = reader.GetInt32(2)
                });
            }
            return categories;
        }
    }

}
