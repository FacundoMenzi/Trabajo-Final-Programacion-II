using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpProgramacion.Servicios.Interfaces;

namespace TpProgramacion.Servicios
{
    abstract class AbstractFactory
    {
        public abstract IServicio CrearServicio();

    }
}
