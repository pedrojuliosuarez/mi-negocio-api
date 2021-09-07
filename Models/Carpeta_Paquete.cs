
using System.Collections.Generic;

namespace mi_negocio_api.Models
{
    public class Carpeta_Paquete
    {
        public int Id { get; set; }
        public int CarpetaId { get; set; }
        public Carpeta Carpeta { get; set; }
        public List<SubCarpeta> SubCarpetas { get; set; }
    }
}