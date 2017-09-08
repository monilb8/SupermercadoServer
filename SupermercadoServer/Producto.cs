using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer
{
    public class Producto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
    }
}