using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpProgramacion.Dominio
{
    internal class DetalleTecnicatura
    {
        
        public Materias Materia { get; set; }
        public int Cuatrimestre { get; set; }
        public int AñoCursado { get; set; }
        public DetalleTecnicatura()
        {

        }
        public DetalleTecnicatura(Materias m, int cuatr,int anio)
        {
            Materia=m;
            Cuatrimestre=cuatr;
            AñoCursado=anio;
        }

        
        
    }
}
