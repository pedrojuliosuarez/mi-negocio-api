
using System.Collections.Generic;

namespace mi_negocio_api.Models
{
    public class CarpetaId_PaqueteId
    {
        public int Id { get; set; }
        public int CarpetaId { get; set; }
        public Carpeta Carpeta { get; set; }
        public int Carpeta_PaqueteId { get; set; }
        public Carpeta_Paquete Carpeta_Paquete { get; set; }
    }
}