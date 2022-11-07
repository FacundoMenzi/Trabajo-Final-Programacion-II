using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_API.Dominio
{
    public class DetalleTecnicatura
    {
        
        public Materia Materia { get; set; }
        public int Cuatrimestre { get; set; }
        public int AñoCursado { get; set; }
        public DetalleTecnicatura()
        {

        }
        public DetalleTecnicatura(Materia m, int cuatr,int anio)
        {
            Materia=m;
            Cuatrimestre=cuatr;
            AñoCursado=anio;
        }

        
        
    }
}
