using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpProgramacion.Dominio
{
    internal class DetalleTecnicatura
    {
        public DetalleTecnicatura(Materias i, int cant)
        {
            I = i;
            Cant = cant;
        }

        public int Id { get; set; }
        public Materias materia { get; set; }
        public int Cuatrimestre { get; set; }
        public int AñoCursado { get; set; }
        public Materias I { get; }
        public int Cant { get; }
    }
}
