using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpleadoApp.Model;
using EmpleadoAppRepository.Interface;
using System.Data.Entity;

namespace EmpleadoAppRepository
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private EmpleadoContext _context = new EmpleadoContext();

        public EmpleadoRepository(EmpleadoContext context)
        {
            this._context = context;
        }

        public async Task<List<Empleadoes>> Get()
        {
            return await _context.Empleado.ToListAsync();
        }

        public async Task<bool> Add(Empleadoes empleado)
        {
          
            _context.Empleado.Add(empleado);
            int x = await _context.SaveChangesAsync();
            return x == 0 ? false : true;
        }
    }
}
