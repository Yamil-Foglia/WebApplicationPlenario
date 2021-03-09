using Plenario.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Data.Contexts
{
    public class MainContext: DbContext
    {
        public MainContext() : base("MainContext") {}

        public DbSet<Persona> Personas{ get; set;}
        public DbSet<Telefono> Telefonos{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
