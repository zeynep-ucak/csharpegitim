using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi (SQLite) *****");
            Console.WriteLine();

            string dbFile = "EgitimKampiDb.db";
            string connectionString = $"Data Source={dbFile}";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

               
                var createCmd = connection.CreateCommand();
                createCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS TblCategory(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CategoryName TEXT NOT NULL
                    );";
                createCmd.ExecuteNonQuery();

               
                var countCmd = connection.CreateCommand();
                countCmd.CommandText = "SELECT COUNT(1) FROM TblCategory;";
                var count = Convert.ToInt32(countCmd.ExecuteScalar() ?? 0);
                if (count == 0)
                {
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = @"
                        INSERT INTO TblCategory (CategoryName) VALUES
                        ('Çorbalar'), ('Ana Yemekler'), ('Soğuk Başlangıçlar'), ('Salatalar');";
                    insertCmd.ExecuteNonQuery();
                }

             
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM TblCategory;";
                using (var reader = selectCmd.ExecuteReader())
                {
                    var table = new DataTable();
                    table.Load(reader);

                    foreach (DataRow row in table.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine();
                    }
                }

                connection.Close();
            }

            Console.WriteLine();
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
