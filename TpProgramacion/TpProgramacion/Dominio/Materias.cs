using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpProgramacion.Dominio
{
    internal class Materias
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Materias()
        {

        }
        public Materias(int id,string nom)
        {
            Id = id;
            Nombre = nom;
        }

    }
}
