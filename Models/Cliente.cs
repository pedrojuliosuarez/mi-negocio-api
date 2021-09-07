
using System.Collections.Generic;

namespace mi_negocio_api.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Telefono> Telefonos { get; set; }
    }
}