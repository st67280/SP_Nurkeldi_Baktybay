using SP_Nurkeldi_Baktybay.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Nurkeldi_Baktybay.DataBase
{
    public class UserRepository
    {
        private readonly string _connectionString = "Data Source=database.db";

        public User GetUserById(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand("SELECT * FROM User WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2)
                };
            }
            return null;
        }
    }

}
