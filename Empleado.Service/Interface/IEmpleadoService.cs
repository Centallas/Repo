using System.Collections.Generic;
using System.Threading.Tasks;
using EmpleadoApp.Model;
using System;



namespace EmpleadoApp.Service.Interface
{
    public interface IEmpleadoService
    {

        Task<List<Empleadoes>> Get();
        Task<bool> Add(Empleadoes empleado);
    }
}
