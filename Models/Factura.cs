
using System.Collections.Generic;

namespace mi_negocio_api.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }
        public double Precio { get; set; }
        public double Gasto { get; set; }
    }
}