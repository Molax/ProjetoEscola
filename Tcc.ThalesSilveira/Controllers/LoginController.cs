using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tcc.ThalesSilveira.Models;

namespace Tcc.ThalesSilveira.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
                return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(Login usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var userId = new TCCEscola.Bll.Login().LoginUser(usuario.login, usuario.password);
        //        if (userId != 0)
        //        {
        //            Session["usuarioLogadoID"] = userId;

        //            return Redirect("PaginaInicial");
        //        }
        //        else
        //        {
        //            ViewBag.errorMessage = "Usuário e senha inválidos!";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        ViewBag.errorMessage = "Digite todos os campos corretamente!";
        //        return View();
        //    }
        //}

        //public ActionResult Logout()
        //{
        //    Session["usuarioLogadoID"] = null;
        //    return RedirectToAction("Index");
        //}
    }
}