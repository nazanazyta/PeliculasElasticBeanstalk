using Microsoft.AspNetCore.Mvc;
using PeliculasElasticBeanstalk.Models;
using PeliculasElasticBeanstalk.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasElasticBeanstalk.Controllers
{
    public class PeliculasController: Controller
    {
        RepositoryPeliculas Repo;

        public PeliculasController(RepositoryPeliculas repo)
        {
            this.Repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.Repo.GetPeliculas());
        }

        public IActionResult Details(int id)
        {
            return View(this.Repo.FindPelicula(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int idpelicula, String titulo, String genero, String director)
        {
            this.Repo.CreatePelicula(idpelicula, titulo, genero, director);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(this.Repo.FindPelicula(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, String titulo, String genero, String director)
        {
            this.Repo.EditPelicula(id, titulo, genero, director);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            this.Repo.DeletePelicula(id);
            return RedirectToAction("Index");
        }
    }
}