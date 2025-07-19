using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net  sql yapılarını kullanmak için
            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;



            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");

            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber= Console.ReadLine();
            Console.WriteLine("----------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=ENES\\SQLEXPRESS;initial Catalog =EgitimKampiDb;" +
                "integrated security=true");  //Bu satırda bir SQL Server veritabanı bağlantısı oluşturuluyor.
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
           connection.Close();

            foreach (DataRow row in dataTable.Rows)  //dataTable.Rows: Tüm satırları temsil eder.
            {
                foreach (var item in row.ItemArray)  //row.ItemArray: O satırdaki hücrelerin (kolonların) tümü.
                {

                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            

            Console.Read();
        }
    }
}
