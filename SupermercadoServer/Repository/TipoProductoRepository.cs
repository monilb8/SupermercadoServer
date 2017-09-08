using SupermercadoServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SupermercadoServer.Repository
{
    public class TipoProductoRepository : ITipoProductoRepository
    {
        public TipoProducto Create(TipoProducto TipoProducto)
        {
            return ApplicationDbContext.applicationDbContext.TipoProducto.Add(TipoProducto);
        }

        public TipoProducto Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.TipoProducto.Find(id);
        }

        public IQueryable<TipoProducto> Get()
        {
            IList<TipoProducto> lista = new List<TipoProducto>(ApplicationDbContext.applicationDbContext.TipoProducto);

            return lista.AsQueryable();
        }


        public void Put(TipoProducto TipoProducto)
        {
            if (ApplicationDbContext.applicationDbContext.TipoProducto.Count(e => e.Id == TipoProducto.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(TipoProducto).State = EntityState.Modified;
        }

        public TipoProducto Delete(long id)
        {
            TipoProducto TipoProducto = ApplicationDbContext.applicationDbContext.TipoProducto.Find(id);
            if (TipoProducto == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.TipoProducto.Remove(TipoProducto);
            return TipoProducto;
        }
    }
}