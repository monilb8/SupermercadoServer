using SupermercadoServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer.Servicios
{
    public class ProductoService: IProductoService
    {
        private IProductoRepository ProductoReposistory;
        public ProductoService(IProductoRepository _ProductoRepository)
        {
            this.ProductoReposistory = _ProductoRepository;
        }

        public Producto Get(long id)
        {
            return ProductoReposistory.Get(id);
        }

        public IQueryable<Producto> Get()
        {
            return ProductoReposistory.Get();
        }

        public Producto Create(Producto Producto)
        {
            return ProductoReposistory.Create(Producto);
        }

        public void Put(Producto Producto)
        {
            ProductoReposistory.Put(Producto);
        }

        public Producto Delete(long id)
        {
            return ProductoReposistory.Delete(id);
        }
    }
}