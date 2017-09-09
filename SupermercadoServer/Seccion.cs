using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer
{
    public class Seccion
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Consumible { get; set; }
        //public string Encargado { get; set; }
    }
}