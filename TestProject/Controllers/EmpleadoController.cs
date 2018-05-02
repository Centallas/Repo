using EmpleadoApp.Model;
using EmpleadoApp.Service.Interface;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class EmpleadoController : Controller
    {

        private IEmpleadoService _service;
        public EmpleadoController(IEmpleadoService service)
        {
            this._service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var res = Json(await _service.Get(), JsonRequestBehavior.AllowGet);
            return res;
           
        }

        [HttpPost]
        public async Task<bool> Post(Empleadoes empleado)
        {
            return await _service.Add(empleado);
        }
    }
}
