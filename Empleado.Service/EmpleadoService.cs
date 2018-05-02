using EmpleadoApp.Service.Interface;
using EmpleadoAppRepository.Interface;
using EmpleadoApp.Model;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace EmpleadoApp.Service
{
    public class EmpleadoService : IEmpleadoService
    {
        private IEmpleadoRepository __repo;

        public EmpleadoService(IEmpleadoRepository repo)
        {

            this.__repo = repo;
        }
        public async Task<List<Empleadoes>> Get()
        {
            return await __repo.Get();
        }
        public async Task<bool> Add(Empleadoes empleado)
        {
            return await __repo.Add(empleado);
        }

    }
}
