using FrontTecnicaturas.Servicios.Implementaciones;
using FrontTecnicaturas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrontTecnicaturas.Servicios
{
    internal class Factory : AbstractFactory
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
