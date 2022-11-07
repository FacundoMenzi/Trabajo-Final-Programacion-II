using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_API.Dominio
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Profesor(int id, string nombre)
        {
            this.Id = id;
            Nombre = nombre;
        }
        public Profesor()
        {

        }
    }
}
