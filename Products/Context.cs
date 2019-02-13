namespace Products
{
    using Products.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Products.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        {
            Database.SetInitializer(new SchoolDBInitializer());
        }
        
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Propertie> Properties { get; set; }


    }
    public class SchoolDBInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            IList<Product> prs = new List<Product>();
            IList<Description> descs = new List<Description>();
            IList<Propertie> props = new List<Propertie>();
            var prod = new Product() { Link = "https://ru.wikipedia.org/wiki/@world_record_egg", Name = "Eggs" };

            descs.Add(new Description() { Text = "Boolshit", Category = "Food",Price = 34.85,Product=prod});
            props.Add(new Propertie() {  Link = "https://www.incredibleegg.org/egg-nutrition/" ,Product=prod});
            props.Add(new Propertie() {  Link = "https://www.seriouseats.com/recipes/images/2017/08/5708631471_06fed03518_o-1500x1125.jpg", Product = prod });
            props.Add(new Propertie() { Link = "https://cdn1.medicalnewstoday.com/content/images/articles/323/323001/bowl-full-of-eggs.jpg", Product = prod });

     


          //  context.Products.AddRange(prs);
            context.Descriptions.AddRange(descs);
            context.Properties.AddRange(props);
            context.SaveChanges();

           // base.Seed(context);
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

}