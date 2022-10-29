using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpProgramacion.Dominio
{
    internal class Tecnicatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public int Estado { get; set; }
        public List<DetalleTecnicatura> Detalles { get; set; }

        public Tecnicatura()
        {
            Detalles = new List<DetalleTecnicatura>();
            Estado = 1;
        }

        public void Agregar(DetalleTecnicatura detalle)
        {
            Detalles.Add(detalle);
        }
        public void Eliminar(int index)
        {
            Detalles.RemoveAt(index);
        }

    }
}
