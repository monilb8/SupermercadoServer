using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoServer.Servicios
{
    public interface ITipoProductoService
    {
        TipoProducto Create(TipoProducto tipoProducto);
        TipoProducto Get(long id);
        IQueryable<TipoProducto> Get();
        void Put(TipoProducto tipoProducto);
        TipoProducto Delete(long id);
    }
}
