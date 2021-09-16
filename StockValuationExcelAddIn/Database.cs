using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockValuationExcelAddIn
{
    public class Database
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public string GetApi()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(Database.connectionString);
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
            cnn = new SqlConnection(Database.connectionString);
            cnn.Open();
            SqlCommand command;
            String sql;
            sql = "UPDATE [dbo].[Table] SET [API] = '" + symbol + "' WHERE [id] = 1";
            try
            {
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                MessageBox.Show("Saved API to Database.");
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding Symbol to Database.");
                MessageBox.Show(ex.Message);

                cnn.Close();
            }
        }

        public string GetCurentTicker()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(Database.connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "SELECT [SYMBOL] FROM [dbo].[Table];";
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

        public void SaveCurrentTicker(string symbol)
        {
            SqlConnection cnn;
            SqlDataReader dataReader;
            cnn = new SqlConnection(Database.connectionString);
            cnn.Open();
            SqlCommand command;
            String sql;
            sql = "UPDATE [dbo].[Table] SET [SYMBOL] = '" + symbol + "' WHERE [id] = 1";
            try
            {
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                MessageBox.Show("Added Symbol to DB.");
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding Symbol to Database.");
                MessageBox.Show(ex.Message);

                cnn.Close();
            }
        }
    }
}
