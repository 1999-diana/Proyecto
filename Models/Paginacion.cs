using System.Collections.Generic;

namespace Proyecto.Models
{
    public class Paginacion
    {
        public IEnumerable<IEntidad> entidades { get; set; }
       
        public int PaginaActual { get; set; }
        public int TotalDeRegistros { get; set; }
        public int RegistrosPorPagina { get; set; }
    }
}
