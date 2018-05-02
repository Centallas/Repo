using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpleadoApp.Model;

namespace EmpleadoAppRepository
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext() : base("DefaultConnection")
        {

        }

        public DbSet<Empleadoes> Empleado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmpleadoContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
