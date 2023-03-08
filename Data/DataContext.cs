using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P203.Data
{
    public class DataContext:DbContext
    {
        DbSet<Customer> Customers { get; set; }
        public DataContext() : base("name=con")
        {
                       
        }
        

        
    }
}
