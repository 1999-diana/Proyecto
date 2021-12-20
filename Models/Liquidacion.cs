namespace Proyecto.Models
{
    public class Liquidacion:IEntidad
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string periodoCesa { get; set; }
        public string periodoPri { get; set; }
        public string periodoVaca { get; set; }
        public double salarioBase { get; set; }
        public double auxilioTrans { get; set; }
        public string tipoContrato{get;set; }


    }
}
