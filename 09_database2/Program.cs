using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_database2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Read,Delete,Update,Create
            Console.WriteLine("**** Menü Sipariş İşlem Paneli ****");
            Console.WriteLine();
            Console.WriteLine("----------------------");

            #region Kategori ekleme işlemi
            //Console.WriteLine("Eklemek istediğiniz kategori adı :");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=ENES\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection); //(name,price,stock) (@p1,@p2,@p3)
            // command.Parameters.AddWithValue("@p1",categoryName);                                                  //name=p1,price=p2...olur.
            //command.ExecuteNonQuery();//sorgu olmadan çalıştır.
            //connection.Close();

            //Console.WriteLine("kategori eklendi");
            #endregion

            #region Ürün ekleme işlemi

            // string productName;
            // decimal productPrice;
            //// bool productStatus;
            // Console.Write("eklemek istediğiniz ürün adı:");
            // productName=Console.ReadLine();
            // Console.Write("Ürün fiyatı:");
            // productPrice=decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source=ENES\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            // connection.Open();

            // SqlCommand  command= new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus)" +
            //     " values (@productName,@productPrice,@productStatus)",connection);

            // command.Parameters.AddWithValue("@productName",productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // command.ExecuteNonQuery();//değişiklikleri kaydet ve veri tabanına yansıt.
            // connection.Close();

            // Console.WriteLine("ürün eklendi");

            #endregion

            #region ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=ENES\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)  //dataTable.Rows: Tüm satırları temsil eder.
            //{
            //    foreach (var item in row.ItemArray)  //row.ItemArray: O satırdaki hücrelerin (kolonların) tümü.
            //    {

            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region ürün silme
            //Console.Write("silinecek ürün ıd:");
            //int productId= int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ENES\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@ProductId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("silindi");



            #endregion

            #region güncelleme

            //Console.Write("güncellenecek ürün ıd:");
            //int productId= int.Parse(Console.ReadLine());

            //Console.Write("güncellenecek ürün adı:");
            //string productName = Console.ReadLine();

            //Console.Write("güncellenecek ürün fiyatı:");
            //decimal productPrice = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=ENES\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set " +
            //    "ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("güncellendi");



            #endregion



            //Console.Read();

        }
    }
}
