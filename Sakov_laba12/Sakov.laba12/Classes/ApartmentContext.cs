using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba12
{
    class ApartmentContext : DbContext
    {
        public ApartmentContext()
    : base("DbConnection")
        { }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Adress> Adresses { get; set; }

    }
}
