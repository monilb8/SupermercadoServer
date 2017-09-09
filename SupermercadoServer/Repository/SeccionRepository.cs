using SupermercadoServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SupermercadoServer.Repository
{
    public class SeccionRepository : ISeccionRepository
    {
        public Seccion Create(Seccion Seccion)
        {
            return ApplicationDbContext.applicationDbContext.Seccion.Add(Seccion);
        }

        public Seccion Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Seccion.Find(id);
        }

        public IQueryable<Seccion> Get()
        {
            IList<Seccion> lista = new List<Seccion>(ApplicationDbContext.applicationDbContext.Seccion);

            return lista.AsQueryable();
        }


        public void Put(Seccion Seccion)
        {
            if (ApplicationDbContext.applicationDbContext.Seccion.Count(e => e.Id == Seccion.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(Seccion).State = EntityState.Modified;
        }

        public Seccion Delete(long id)
        {
            Seccion Seccion = ApplicationDbContext.applicationDbContext.Seccion.Find(id);
            if (Seccion == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Seccion.Remove(Seccion);
            return Seccion;
        }
    }
}