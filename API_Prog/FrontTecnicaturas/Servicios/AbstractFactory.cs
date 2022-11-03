using FrontTecnicaturas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrontTecnicaturas.Servicios
{
    abstract class AbstractFactory
    {
        public abstract IServicio CrearServicio();

    }
}
