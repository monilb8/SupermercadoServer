using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoServer.Servicios
{
    public interface IProductoService
    {
        Producto Create(Producto producto);
        Producto Get(long id);
        IQueryable<Producto> Get();
        void Put(Producto producto);
        Producto Delete(long id);
    }
}
