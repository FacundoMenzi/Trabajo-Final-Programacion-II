using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinNetFramework
{
    public class ParametroFramework
    {
        public string Clave { get; set; }
        public object Valor { get; set; }

        public ParametroFramework(string clave, object valor)
        {
            Clave = clave;
            Valor = valor;
        }
    }
}
