using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_part_2
{
    public class Queries
    {
        private static string connectionString = @"Data Source=DESKTOP-PFI6MSV\SQLEXPRESS;Initial Catalog=Stationery_firm; Integrated Security=True;TrustServerCertificate=True;";
        public static string ShowAllStationery(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select * from Stationery";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string ShowAllTypeStationery(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select distinct Type from Stationery";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    int a = 0;
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += a + 1 + ")" + reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                        a++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string ShowAllManager(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select distinct * from Manager";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string ShowMaxCountStationery(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select * from Stationery where Count = (select Max(Count) from Stationery)";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string ShowMinCountStationery(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select * from Stationery where Count = (select Min(Count) from Stationery)";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string ShowMaxPriceStationery(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select * from Stationery where Price = (select Max(Price) from Stationery)";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string ShowMinPriceStationery(TextBox textBox)
        {
            textBox.Text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "Select * from Stationery where Price = (select Min(Price) from Stationery)";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox.Text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        textBox.Text += (new string('_', 30));
                        textBox.Text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    textBox.Text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return textBox.Text;
            }
        }
        public static string SearchBytype(string text)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdProc = new SqlCommand("dbo.ShowStationeryByType", connection) { CommandType = System.Data.CommandType.StoredProcedure };

                cmdProc.Parameters.AddWithValue("@TypeName", $"{text}");

                connection.Open();
                SqlDataReader reader = cmdProc.ExecuteReader();
                text = null;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        text += System.Environment.NewLine + reader.GetName(i) + ": " + reader[i];
                    }
                    text += System.Environment.NewLine + "======================= " + System.Environment.NewLine;
                }
                if (reader.FieldCount == 0)
                {
                    text = "Error type name!!!";
                }
                connection.Close();
            }
            return text;
        }
        public static string SearchManager(string text)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdProc = new SqlCommand("dbo.ShowManagerHadSold", connection) { CommandType = System.Data.CommandType.StoredProcedure };

                cmdProc.Parameters.AddWithValue("@TypeName", $"{text}");

                connection.Open();
                SqlDataReader reader = cmdProc.ExecuteReader();
                text = null;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        text += System.Environment.NewLine + reader.GetName(i) + ": " + reader[i];
                    }
                    text += System.Environment.NewLine + "======================= " + System.Environment.NewLine;
                }
                if (reader.FieldCount == 0)
                {
                    text = "Error type name!!!";
                }
                connection.Close();
            }
            return text;
        }
        public static string SearchFirma(string text)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdProc = new SqlCommand("dbo.SearchSoldByFirma", connection) { CommandType = System.Data.CommandType.StoredProcedure };

                cmdProc.Parameters.AddWithValue("@TypeName", $"{text}");

                connection.Open();
                SqlDataReader reader = cmdProc.ExecuteReader();
                text = null;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        text += System.Environment.NewLine + reader.GetName(i) + ": " + reader[i];
                    }
                    text += System.Environment.NewLine + "======================= " + System.Environment.NewLine;
                }
                if (reader.FieldCount == 0)
                {
                    text = "Error name firma!!!";
                }
                connection.Close();
            }
            return text;
        }
        public static string lastBoughStaff(string text)
        {
            text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "select * from Sales where DateBought = (select Max(DateBought) from Sales)";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            text += reader.GetName(i) + " : " + reader[i] + Environment.NewLine;
                        }
                        text += (new string('_', 30));
                        text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return text;
            }
        }
        public static string AvgCountType(string text)
        {
            text = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                try
                {
                    cmd.CommandText = "SELECT distinct Type,AVG(Count) FROM Stationery group by Type";
                    cmd.Transaction = connection.BeginTransaction();
                    cmd.Transaction.Commit();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            text += reader.GetName(i) + " : " + reader[i];
                        }
                        text += Environment.NewLine;
                        text += (new string('_', 30));
                        text += Environment.NewLine;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    text = $"{ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
                return text;
            }
        }
    }
}

