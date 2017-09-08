using SupermercadoServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SupermercadoServer.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        public Producto Create(Producto Producto)
        {
            return ApplicationDbContext.applicationDbContext.Producto.Add(Producto);
        }

        public Producto Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Producto.Find(id);
        }

        public IQueryable<Producto> Get()
        {
            IList<Producto> lista = new List<Producto>(ApplicationDbContext.applicationDbContext.Producto);

            return lista.AsQueryable();
        }


        public void Put(Producto Producto)
        {
            if (ApplicationDbContext.applicationDbContext.Producto.Count(e => e.Id == Producto.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(Producto).State = EntityState.Modified;
        }

        public Producto Delete(long id)
        {
            Producto Producto = ApplicationDbContext.applicationDbContext.Producto.Find(id);
            if (Producto == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Producto.Remove(Producto);
            return Producto;
        }
    }
}