namespace Proyecto.Models
{
    public class Empleado:IEntidad
    {
        public int id { get; set; }

        public string NombreEmpleado { get; set; }
        public double sueldo { get; set;}
        public double LiquidacionTotal { get; set; }
        public double DicemoTercerSueldo { get; set; }
        public double RoldePagos { get; set; }
         

    }
}
