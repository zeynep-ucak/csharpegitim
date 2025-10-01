using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****\n");

        
            SqlConnection connection;
            SqlCommand command;

            string connectionString = "Data Source=LAPTOP-1GCH58UK;Initial Catalog=EgitimKampiDb;Integrated Security=True";

            #region Kategori Ekleme İşlemi
            Console.Write("Eklemek istediğiniz kategori adı: ");
            string categoryName = Console.ReadLine();

            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("✅ Kategori başarıyla eklendi\n");
            #endregion

            #region Ürün Ekleme İşlemi
            Console.Write("Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand("INSERT INTO TblProduct (ProductName,ProductPrice,ProductStatus) VALUES (@productName,@productPrice,@productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("✅ Ürün başarıyla eklendi\n");
            #endregion

            #region Ürün Listeleme
            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand("SELECT * FROM TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Console.WriteLine("📦 Ürün Listesi:");
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            connection.Close();
            Console.WriteLine();
            #endregion

            #region Ürün Silme
            Console.Write("Silinecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("✅ Ürün silme işlemi tamamlandı\n");
            #endregion

            #region Ürün Güncelleme
            Console.Write("Güncellenecek Ürün Id: ");
            productId = int.Parse(Console.ReadLine());

            Console.Write("Yeni Ürün Adı: ");
            productName = Console.ReadLine();

            Console.Write("Yeni Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice WHERE ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("✅ Güncelleme işlemi başarılı\n");
            #endregion

            Console.ReadLine();
        }
    }
}
