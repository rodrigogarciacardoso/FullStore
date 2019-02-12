using AutoMapper;
using FullStore.Application.Interfaces;
using FullStore.Application.ViewModels;
using FullStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FullStore.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioApplication _usuarioApplication;

        public UsuarioController(IUsuarioApplication usuarioApplication)
            : base()
        {
            _usuarioApplication = usuarioApplication;
        }

        
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuarios
        public ActionResult GetUsuarios()
        {
            var paisViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApplication.GetAll());
            return Json(new { data = paisViewModel });
        }

        // GET: Usuario/Details/5
        public JsonResult Details(Guid id)
        {
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(_usuarioApplication.GetById(id));
            return Json(new { data = usuarioViewModel });
        }
    }
}
