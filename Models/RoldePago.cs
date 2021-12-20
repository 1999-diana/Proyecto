namespace Proyecto.Models
{
    public class RoldePago:IEntidad
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public double sueldobasico { get; set; }
        public double horasextras { get; set; }
        public double comision { get; set; }
        public  double aportes { get; set; }
        public double prestamos { get; set; }

        public double total { get; set; }
        
    }
}
