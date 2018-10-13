using System;
using System.Data.SqlClient;


namespace FucionalSqlLocal
{
    class Program
    {
        static void Main(string[] args)
        {




            string connectionString = String.Format(@"Server=(localdb)\Chinga;Integrated Security=true;");



            Disposable
                .Using(() => new SqlConnection(connectionString),
                    instance =>
                    {
                        instance.Open();
                        var cmd = instance.CreateCommand();

                        cmd.CommandText = "select 5*4";


                        cmd.ExecuteScalar();
                        return instance;
                    });


        }




    }
}
