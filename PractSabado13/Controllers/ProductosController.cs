using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PractSabado13.Models;

namespace PractSabado13.Controllers
{
    public class ProductosController : Controller
    {
        private productosDbConexion _contexto = new productosDbConexion();
        // GET: Productos
        public ActionResult Index()
        {
            string prueba = "<h1> Esta es la practica de DAW del dia 13/11/2021 </h1>";
            return Content(prueba);
        }

        public ActionResult listarProductos()
        {
            var productList = _contexto.producto.ToList();
            return View(productList);
        }


        public ActionResult InsertarProductos()
        {
            var productosLista = _contexto.producto.ToList();
            return View(productosLista);
        }

        public ActionResult Create()
        {
            var productosLista = _contexto.producto.ToList();
            return View("InsertarProductos", productosLista);
        }

        [HttpPost]
        public ActionResult Insert(Productos productoAcrear)
        {
            _contexto.producto.Add(productoAcrear);
            _contexto.SaveChanges();
            return RedirectToAction("InsertarProductos");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var producto = _contexto.producto.Find(id);
            return View(producto);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var producto = _contexto.producto.Find(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Productos productoModificado)
        {

            var producto = _contexto.producto.Find(productoModificado.id_producto);

            producto.FechaProduc = productoModificado.FechaProduc;
            producto.Categoria = productoModificado.Categoria;
            producto.Talla = productoModificado.Talla;
            producto.Color = productoModificado.Color;
            producto.Descripcion = productoModificado.Descripcion;
            producto.Cantidad = productoModificado.Cantidad;

            _contexto.Entry(producto).State = EntityState.Modified;
            _contexto.SaveChanges();

            var productoLista = _contexto.producto.ToList();
            return View("InsertarProductos", productoLista);
        }
    }
}