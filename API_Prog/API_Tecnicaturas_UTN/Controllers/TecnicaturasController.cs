using DLL_API.Dominio;
using DLL_API.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Tecnicaturas_UTN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicaturasController : ControllerBase
    {
        private IDataAPI dataApi; //punto de acceso a la API

        public TecnicaturasController()
        {
            dataApi = new DataAPI_Imp();
        }

        [HttpGet("/materias/ver")]
        public IActionResult GetMaterias()
        {
            List<Materias> lst;
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
        [HttpGet("/tecnicaturas/verAltas")]
        public IActionResult GetTecnicaturasAltas()
        {
            List<Tecnicatura> lst;
            try
            {
                lst = dataApi.GetTecnicaturasAltas();
                return Ok(lst);

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/tecnicaturas/verBajas")]
        public IActionResult GetTecnicaturasBajas()
        {
            IActionResult result;
            List<Tecnicatura> lst;
            try
            {
                
                lst = dataApi.GetTecnicaturasBajas();
                if (lst != null)
                {
                    result= Ok(lst);
                }
                else result = NotFound();
                return result;

            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/tecnicaturas/nueva")]
        public IActionResult PostTecnicatura(Tecnicatura tecnicatura)
        {
            IActionResult result;
            try
            {
                if (tecnicatura == null)
                {
                    result= BadRequest("Datos de tecnicatura incorrectos");
                }

                else result= Ok(dataApi.SaveTecnicatura(tecnicatura));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPut("/tecnicaturas/modificar")]
        public IActionResult PutTecnicatura(Tecnicatura tec)
        {
            IActionResult result;
            try
            {
                if (tec == null)
                {
                    result = BadRequest("Datos de tecnicatura incorrectos");
                }

                else result = Ok(dataApi.UpdateTecnicatura(tec));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPut("/tecnicaturas/darBaja")]
        public IActionResult BajaTecnicatura(Tecnicatura tec)
        {
            IActionResult result;
            try
            {
                if (tec == null)
                {
                    result = BadRequest("Datos de tecnicatura incorrectos");
                }

                else result = Ok(dataApi.BajaTecnicatura(tec,0));
                return result;
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
