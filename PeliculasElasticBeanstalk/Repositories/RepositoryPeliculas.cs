using PeliculasElasticBeanstalk.Data;
using PeliculasElasticBeanstalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasElasticBeanstalk.Repositories
{
    public class RepositoryPeliculas
    {
        PeliculasContext Context;

        public RepositoryPeliculas(PeliculasContext context)
        {
            this.Context = context;
        }

        public List<Pelicula> GetPeliculas()
        {
            return this.Context.Peliculas.ToList();
        }

        public Pelicula FindPelicula(int id)
        {
            return this.Context.Peliculas.SingleOrDefault(x => x.IdPelicula == id);
        }

        public void CreatePelicula(int id, String titulo, String genero, String director)
        {
            Pelicula p = new Pelicula();
            p.IdPelicula = id;
            p.Titulo = titulo;
            p.Genero = genero;
            p.Director = director;
            this.Context.Peliculas.Add(p);
            this.Context.SaveChanges();
        }

        public void EditPelicula(int id, String titulo, String genero, String director)
        {
            Pelicula p = this.FindPelicula(id);
            p.Titulo = titulo;
            p.Genero = genero;
            p.Director = director;
            this.Context.SaveChanges();
        }

        public void DeletePelicula(int id)
        {
            Pelicula p = this.FindPelicula(id);
            this.Context.Peliculas.Remove(p);
            this.Context.SaveChanges();
        }
    }
}
