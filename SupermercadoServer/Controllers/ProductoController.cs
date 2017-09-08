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

    public class ProductoController : ApiController
    {
        private IProductoService productoService;

        public ProductoController(IProductoService _productoService)
        {
            this.productoService = _productoService;
        }

        // GET: api/Producto
        public IQueryable<Producto> GetProducto()
        {
            return productoService.Get();
        }

        // GET: api/Producto/5
        [ResponseType(typeof(Producto))]
        public IHttpActionResult GetProducto(long id)
        {
            Producto Producto = productoService.Get(id);
            if (Producto == null)
            {
                return NotFound();
            }

            return Ok(Producto);
        }

        // PUT: api/Producto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProducto(long id, Producto Producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Producto.Id)
            {
                return BadRequest();
            }

            try
            {
                productoService.Put(Producto);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Producto
        [ResponseType(typeof(Producto))]
        public IHttpActionResult PostProducto(Producto Producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Producto = productoService.Create(Producto);

            return CreatedAtRoute("DefaultApi", new { id = Producto.Id }, Producto);
        }

        // DELETE: api/Producto/5
        [ResponseType(typeof(Producto))]
        public IHttpActionResult DeleteProducto(long id)
        {
            Producto pelicula;
            try
            {
                pelicula = productoService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }
    }
}