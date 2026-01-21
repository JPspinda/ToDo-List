using Microsoft.AspNetCore.Mvc;
using To_Do_List.Models;
using To_Do_List.Repositories.Interfaces;

namespace To_Do_List.Controllers
{
    public class ToDoList : Controller
    {
        private readonly IListaRepositorie _listaRepositorie;

        public ToDoList(IListaRepositorie listaRepositorie)
        {
            _listaRepositorie = listaRepositorie;
        }

        public IActionResult Index()
        {
            var lista = _listaRepositorie.GetLista(1); 

            if(lista == null)
            {
                return View();
            }

            return View(lista);
        }

        public IActionResult CriarLista()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarLista(Lista novaLista)
        {
            _listaRepositorie.CreateList(novaLista);
            return RedirectToAction("Index");
        }

        public IActionResult AddElementoLista(int listaId)
        {
            ViewBag.ListaId = listaId;
            return View();
        }

        [HttpPost]
        public IActionResult AddElementoLista(int listaId, ElementoLista elementoLista)
        
        {
            _listaRepositorie.AddElementosLista(listaId, elementoLista);
            return RedirectToAction("Index");
        }
    }
}
