using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessContext : DbContext
    {
        public BusinessContext() : base("BusinessContext")
        {
            Database.SetInitializer<BusinessContext>(new BusinessContextInitializer());
        }

        public DbSet<Model.Item> Items { get; set; }
    }
}
