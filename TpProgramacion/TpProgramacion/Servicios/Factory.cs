using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpProgramacion.Servicios.Implementaciones;
using TpProgramacion.Servicios.Interfaces;

namespace TpProgramacion.Servicios
{
    internal class Factory : AbstractFactory
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
