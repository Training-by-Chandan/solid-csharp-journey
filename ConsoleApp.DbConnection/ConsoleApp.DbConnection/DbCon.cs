using System.Data.SqlClient;

namespace ConsoleApp.DbConnection
{
    public static class DbCon
    {
        private static string connectionString = "Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Initial Catalog=Console.DbCon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void GetAll()
        {
            //define query
            var query = "select * from PersonInfo";
            runReader(query);
        }

        private static void runReader(string query)
        {
            //Connection object
            SqlConnection con = new SqlConnection(connectionString);
            //command object
            SqlCommand cmd = new SqlCommand(query, con);
            //connection open
            con.Open();
            //execute command
            var reader = cmd.ExecuteReader();
            //do work
            while (reader.Read())
            {
                Console.WriteLine($"Id : {reader.GetFieldValue<int>(0)}");
                Console.WriteLine($"Name : {reader.GetFieldValue<string>(1)}");
                Console.WriteLine($"Email : {reader.GetFieldValue<string>(2)}");
                Console.WriteLine($"Phone : {reader.GetString(3)}");
                Console.WriteLine("========================================");
            }
            //close connection
            con.Close();
        }

        private static void runNonQuery(string query)
        {
            //Connection object
            SqlConnection con = new SqlConnection(connectionString);
            //command object
            SqlCommand cmd = new SqlCommand(query, con);
            //connection open
            con.Open();
            //execute command
            var reader = cmd.ExecuteNonQuery();

            //close connection
            con.Close();
        }

        public static void GetById()
        {
            Console.WriteLine("Enter the id");
            var id = Console.ReadLine();
            //define query
            var query = "select * from PersonInfo where id=" + id;
            runReader(query);
        }

        public static void Create()
        {
            Console.WriteLine("Enter the name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            var phone = Console.ReadLine();

            var query = $"insert into personinfo values ('{name}','{email}','{phone}')";
            runNonQuery(query);
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the id");
            var id = Console.ReadLine();
            Console.WriteLine("Enter the name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            var phone = Console.ReadLine();

            var query = $"update personinfo set name='{name}', email='{email}',phone='{phone}' where id={id}";
            runNonQuery(query);
        }

        public static void Delete()
        {
            Console.WriteLine("Enter the id");
            var id = Console.ReadLine();

            var query = $"delete from personinfo where id={id}";
            runNonQuery(query);
        }
    }
}