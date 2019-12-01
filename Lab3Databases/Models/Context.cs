using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3Databases {
    public class Context : DbContext {

        public Context() { }

        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Buyer>().ToTable("Buyer", "public");
            modelBuilder.Entity<Delivery>().ToTable("Delivery", "public");
            modelBuilder.Entity<Product>().ToTable("Product", "public");
            modelBuilder.Entity<Provider>().ToTable("Provider", "public");
        }
    }


    [Table("Buyer", Schema = "public")]
    public class Buyer {
        public Buyer() { }
        public Buyer(string name, string surname, string login) {
            Name = name;
            Surname = surname;
            Login = login;
        }

        public Buyer(int id, string name, string surname, string login) {
            Id = id;
            Name = name;
            Surname = surname;
            Login = login;
        }

        [Key]
        [Column("buyerid")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("login")]
        public string Login { get; set; }

        //public virtual ICollection<Delivery> Delivery { get; set; }
    }

    [Table("Delivery", Schema = "public")]
    public class Delivery {
        public Delivery(int buyer_id, int product_id, string isdelivered, string date_of_order, string date_of_delivery) {
            this.buyer_id = buyer_id;
            this.product_id = product_id;
            this.isdelivered = isdelivered;
            this.date_of_order = date_of_order;
            this.date_of_delivery = date_of_delivery;
        }

        public Delivery(int id, int buyer_id, int product_id, string isdelivered, string date_of_order, string date_of_delivery) {
            Id = id;
            this.buyer_id = buyer_id;
            this.product_id = product_id;
            this.isdelivered = isdelivered;
            this.date_of_order = date_of_order;
            this.date_of_delivery = date_of_delivery;
        }

        public Delivery() { }

        public Delivery(int id, string isdelivered, string ord, string del) {
            Id = id;
            this.isdelivered = isdelivered;
            date_of_order = ord;
            date_of_delivery = del;
        }
        [Key]
        [Column("deliveryid")]
        public int Id { get; set; }
        [Column("buyer_id")]
        public int buyer_id { get; set; }
        [Column("product_id")]
        public int product_id { get; set; }
        [Column("isdelivered")]
        public string isdelivered { get; set; }
        [Column("date_of_order")]
        public string date_of_order { get; set; }
        [Column("date_of_delivery")]
        public string date_of_delivery { get; set; }

        //public virtual Buyer Buyer { get; set; }
        //public virtual Product Product { get; set; }
    }

    [Table("Product", Schema = "public")]
    public class Product {

        public Product() { }

        public Product(string name, string category, int prod_provider) {
            Name = name;
            Category = category;
            Prod_provider = prod_provider;
        }

        public Product(int id, string name, string category, int prod_provider) {
            Id = id;
            Name = name;
            Category = category;
            Prod_provider = prod_provider;
        }

        [Key]
        [Column("productid")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("prod_provider")]
        public int Prod_provider { get; set; }


        //public virtual ICollection<Delivery> Delivery { get; set; }
        //public virtual Provider Provider { get; set; }
    }

    [Table("Provider", Schema = "public")]
    public class Provider {
        public Provider() { }

        public Provider(string name, string adress, string phone) {
            Name = name;
            Adress = adress;
            Phone = phone;
        }

        public Provider(int id, string name, string adress, string phone) {
            Id = id;
            Name = name;
            Adress = adress;
            Phone = phone;
        }
        [Key]
        [Column("providerid")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("adress")]
        public string Adress { get; set; }
        [Column("phone")]
        public string Phone { get; set; }

        //public virtual ICollection<Product> Product { get; set; }
    }

}
