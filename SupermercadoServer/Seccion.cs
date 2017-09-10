using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer
{
    public class Seccion
    {
        public long Id { get; set; }
        public string NombreSeccion { get; set; }
        public bool Consumible { get; set; }
        public string Encargado { get; set; }
        public string GestionStock { get; set; }
        public string TipoVenta { get; set; }
        public DateTime FechaFrecuenciaStock { get; set; }
    }
}