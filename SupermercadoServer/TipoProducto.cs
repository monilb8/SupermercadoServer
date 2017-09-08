using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer
{
    public class TipoProducto
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public bool Consumible { get; set; }
        public bool Limpieza { get; set; }
        public int Capacidad { get; set; }
        public string TipoEnvase { get; set; }
    }
}