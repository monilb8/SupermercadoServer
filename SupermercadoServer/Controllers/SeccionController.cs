using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using SupermercadoServer.Servicios;

namespace SupermercadoServer.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]

    public class SeccionController : ApiController
    {
        private ISeccionService SeccionService;

        public SeccionController(ISeccionService _SeccionService)
        {
            this.SeccionService = _SeccionService;
        }

        // GET: api/Seccion
        public IQueryable<Seccion> GetSeccion()
        {
            return SeccionService.Get();
        }

        // GET: api/Seccion/5
        [ResponseType(typeof(Seccion))]
        public IHttpActionResult GetSeccion(long id)
        {
            Seccion Seccion = SeccionService.Get(id);
            if (Seccion == null)
            {
                return NotFound();
            }

            return Ok(Seccion);
        }

        // PUT: api/Seccion/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSeccion(long id, Seccion Seccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Seccion.Id)
            {
                return BadRequest();
            }

            try
            {
                SeccionService.Put(Seccion);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Seccion
        [ResponseType(typeof(Seccion))]
        public IHttpActionResult PostUsuario(Seccion Seccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Seccion = SeccionService.Create(Seccion);

            return CreatedAtRoute("DefaultApi", new { id = Seccion.Id }, Seccion);
        }

        // DELETE: api/Seccion/5
        [ResponseType(typeof(Seccion))]
        public IHttpActionResult DeleteSeccion(long id)
        {
            Seccion Seccion;
            try
            {
                Seccion = SeccionService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(Seccion);
        }
    }
}