using SupermercadoServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer.Servicios
{
    public class TipoProductoService : ITipoProductoService
    {
        private ITipoProductoRepository TipoProductoRepository;
        public TipoProductoService(ITipoProductoRepository _TipoProductoRepository)
        {
            this.TipoProductoRepository = _TipoProductoRepository;
        }

        public TipoProducto Get(long id)
        {
            return TipoProductoRepository.Get(id);
        }

        public IQueryable<TipoProducto> Get()
        {
            return TipoProductoRepository.Get();
        }

        public TipoProducto Create(TipoProducto TipoProducto)
        {
            return TipoProductoRepository.Create(TipoProducto);
        }

        public void Put(TipoProducto TipoProducto)
        {
            TipoProductoRepository.Put(TipoProducto);
        }

        public TipoProducto Delete(long id)
        {
            return TipoProductoRepository.Delete(id);
        }
    }
}