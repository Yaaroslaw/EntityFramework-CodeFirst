using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst
{
    public class SampleContext :DbContext
    {
        // Use a contructor of a base class DbContext
        // to specify the name of our db
        public SampleContext() : base("TestDBase") { }


        // Our'context', prop to use the info from the tables
        public DbSet<Model.Customer> Customers { get; set; }
        public DbSet<Model.Order> Orders { get; set; }
    }
}
