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

    public class TipoProductoController : ApiController
    {
        private ITipoProductoService TipoProductoService;

        public TipoProductoController(ITipoProductoService _TipoProductoService)
        {
            this.TipoProductoService = _TipoProductoService;
        }

        // GET: api/TipoProducto
        public IQueryable<TipoProducto> GetTipoProducto()
        {
            return TipoProductoService.Get();
        }

        // GET: api/TipoProducto/5
        [ResponseType(typeof(TipoProducto))]
        public IHttpActionResult GetTipoProducto(long id)
        {
            TipoProducto TipoProducto = TipoProductoService.Get(id);
            if (TipoProducto == null)
            {
                return NotFound();
            }

            return Ok(TipoProducto);
        }

        // PUT: api/TipoProducto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoProducto(long id, TipoProducto TipoProducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != TipoProducto.Id)
            {
                return BadRequest();
            }

            try
            {
                TipoProductoService.Put(TipoProducto);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoProducto
        [ResponseType(typeof(TipoProducto))]
        public IHttpActionResult PostUsuario(TipoProducto TipoProducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TipoProducto = TipoProductoService.Create(TipoProducto);

            return CreatedAtRoute("DefaultApi", new { id = TipoProducto.Id }, TipoProducto);
        }

        // DELETE: api/TipoProducto/5
        [ResponseType(typeof(TipoProducto))]
        public IHttpActionResult DeleteTipoProducto(long id)
        {
            TipoProducto TipoProducto;
            try
            {
                TipoProducto = TipoProductoService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(TipoProducto);
        }
    }
}