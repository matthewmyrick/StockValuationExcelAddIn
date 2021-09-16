using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Testing
{
    public class Database
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        public static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\matth\\OneDrive\\Documents\\GitHub\\StockValuationExcelAddIn\\StockValuationExcelAddIn\\Database.mdf;Integrated Security = True";
        public string GetApi()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(Database.connString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "SELECT [API] FROM [dbo].[Table];";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetString(0);
            }
            Output = Output.Replace(" ", "");
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            return Output;
        }

        public void SaveApi(string symbol)
        {
            SqlConnection cnn;
            SqlDataReader dataReader;
            cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\matth\\OneDrive\\Documents\\GitHub\\StockValuationExcelAddIn\\StockValuationExcelAddIn\\Database.mdf;Integrated Security=True");
            cnn.Open();
            SqlCommand command;
            String sql;
            sql = "UPDATE [dbo].[Table] SET [API] = '" + symbol + "' WHERE [id] = 1";
            try
            {
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                Console.WriteLine("Saved API to Database.");
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Adding Symbol to Database");
                Console.WriteLine(ex.Message);
                cnn.Close();
            }
        }
    }
}
