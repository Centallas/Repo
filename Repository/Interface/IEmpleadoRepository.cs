using EmpleadoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoAppRepository.Interface
{
    public interface IEmpleadoRepository
    {
        Task<List<Empleadoes>> Get();
        Task<bool> Add(Empleadoes empleado);
    }
}
