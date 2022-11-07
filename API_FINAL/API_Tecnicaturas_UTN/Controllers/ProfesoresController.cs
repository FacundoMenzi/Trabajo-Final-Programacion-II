using DLL_API.Dominio;
using DLL_API.Fachada;
using Microsoft.AspNetCore.Mvc;

namespace API_Tecnicaturas_UTN.Controllers
{
    public class ProfesoresController : Controller
    {
        private IDataAPI dataApi; 

        public ProfesoresController()
        {
            dataApi = new DataAPI_Imp();
        }
        [HttpGet("/profesores/ver")]
        public IActionResult GetProfesores()
        {
            List<Profesor> lst;
            try
            {
                lst = dataApi.GetProfesores();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
