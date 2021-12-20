using System;

namespace Proyecto.Models
{
    public class DecimoTercer:IEntidad
    {
      

        public int Id { get;  set; }
       
        public string NombreEmpleado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechafin { get; set; }
        public string meses { get; set; }
        public double total { get; set; }



    }
}
