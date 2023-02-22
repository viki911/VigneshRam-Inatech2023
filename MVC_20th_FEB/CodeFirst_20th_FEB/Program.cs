 using EF_console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_console
{
    internal class Program
    {
        public static void InsertProduct() 
        {
            using (var dbcon = new ProductContext())
            {
                Product product = new Product();
                product.Name = "Cintol";
                dbcon.Add(product);
                product = new Product();
                product.Name = "Dettol";
                dbcon.Add(product);
                dbcon.SaveChanges();
            }
            return;

        }
        public static void InsKey()
        {
            using (var dbcon = new ProductContext())
            {
              Kkey k = new Kkey();
                k.KName = "Key1A";
                k = new Kkey();
                k.Kfid = 3;
                dbcon.Add(k);
                dbcon.SaveChanges();
             

            }
            return;

        }
        public static void InsertKey()
        {
            using (var dbcon = new ProductContext())
            {
                ForKey fk = new ForKey();
                fk.Name = "Key2";
                dbcon.Add(fk);
                fk = new ForKey();
                fk.Name = "Key3";
                dbcon.Add(fk);
                fk = new ForKey();
                fk.Name = "Key4";
                dbcon.Add(fk);
                
                dbcon.SaveChanges();
            }
            return;

        }

        public static void ReadProduct() 
        {
            using(var dbcon = new ProductContext()) 
            {
                //List<Product> prods = new List<Product>();  
                foreach (var pr in dbcon.Products) { Console.WriteLine(pr.Name + " " +pr.Id); }
            }
        
        }

        public static void UpdateProduct()
        {
            using(var dbcon = new ProductContext())
            {
                Product ? prd = dbcon.Products.Find(2);
                prd.Name = "Cintol";
                dbcon.SaveChanges();
            }
        }

        public static void DeleteProduct()
        {
            using (var dbcon = new ProductContext())
            {
                Product product= dbcon.Products.Find(4);
                dbcon.Products.Remove(product);
                dbcon.SaveChanges();    
            }
        }

        public static void ProdBatch()
        {
            using(var dbcon = new ProductContext())
            {
                ProductBatch pro = new ProductBatch();
                pro.BatchId = 1;
                pro.Quantity = 10;
                pro.Price = 100;
                pro.Desc = "This is a LifeBouy product";
                
            }
        }
        public static void Main(string[] args) 
        {
            //InsertProduct();
            //UpdateProduct();
            //DeleteProduct();
            //ReadProduct();
            InsertKey();
            InsKey();
            Console.WriteLine("Success");
        }
    }
}
