using SupermercadoServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupermercadoServer.Servicios
{
    public class SeccionService : ISeccionService
    {
        private ISeccionRepository SeccionRepository;
        public SeccionService(ISeccionRepository _SeccionRepository)
        {
            this.SeccionRepository = _SeccionRepository;
        }

        public Seccion Get(long id)
        {
            return SeccionRepository.Get(id);
        }

        public IQueryable<Seccion> Get()
        {
            return SeccionRepository.Get();
        }

        public Seccion Create(Seccion Seccion)
        {
            return SeccionRepository.Create(Seccion);
        }

        public void Put(Seccion Seccion)
        {
            SeccionRepository.Put(Seccion);
        }

        public Seccion Delete(long id)
        {
            return SeccionRepository.Delete(id);
        }
    }
}