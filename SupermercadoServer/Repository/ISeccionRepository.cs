using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoServer.Repository
{
    public interface ISeccionRepository
    {
        Seccion Create(Seccion seccion);
        Seccion Get(long id);
        IQueryable<Seccion> Get();
        void Put(Seccion seccion);
        Seccion Delete(long id);
    }
}
