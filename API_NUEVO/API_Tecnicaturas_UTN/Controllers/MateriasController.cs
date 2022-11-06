using DLL_API.Dominio;
using DLL_API.Fachada;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Tecnicaturas_UTN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private IDataAPI dataApi; //punto de acceso a la API

        public MateriasController()
        {
            dataApi = new DataAPI_Imp();
        }
        [HttpGet("/materias/ver")]
        public IActionResult GetMaterias()
        {
            List<Materia> lst;
            try
            {
                lst = dataApi.GetMaterias();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/materias/verBajas")]
        public IActionResult GetMateriasBajas()
        {
            List<Materia> lst;
            try
            {
                lst = dataApi.GetMateriasBajas();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/materias/proxima")]
        public IActionResult GetProximaMateria()
        {
            int prox;
            try
            {
                prox = dataApi.GetProximaMateria();
                return Ok(prox);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/materias/nueva")]
        public IActionResult PostMateria(Materia materia)
        {
            IActionResult result;
            try
            {
                if (materia == null)
                {
                    result = BadRequest("Datos de materia incorrectos");
                }

                else result = Ok(dataApi.SaveMateria(materia));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPut("/materias/modificar")]
        public IActionResult PutMateria(Materia mat)
        {
            IActionResult result;
            try
            {
                if (mat == null)
                {
                    result = BadRequest("Datos de materia incorrectos");
                }

                else result = Ok(dataApi.UpdateMateria(mat));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPut("/materias/darBaja")]
        public IActionResult BajaMateria(Materia mat)
        {
            IActionResult result;
            try
            {
                if (mat == null)
                {
                    result = BadRequest("Datos de materia incorrectos");
                }

                else result = Ok(dataApi.AltaBajaMateria(mat, 0));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPut("/materias/darAlta")]
        public IActionResult AltaMateria(Materia mat)
        {
            IActionResult result;
            try
            {
                if (mat == null)
                {
                    result = BadRequest("Datos de materia incorrectos");
                }

                else result = Ok(dataApi.AltaBajaMateria(mat, 1));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
