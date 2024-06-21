using System.Data.SqlClient;

namespace TestADO.Manager
{
    public class UserManager:IUserManager
    {
        private readonly SqlConnection connection;
        public UserManager() 
        { 
            connection = new SqlConnection(Constants.ConnectionString);
        }
        public void ListUsers()
        {
            using (SqlCommand cmd = new SqlCommand("select * from UsersTb", connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine((int) reader["id"]);
                }
            }
        }


        public void UpdateUser
    }
}
