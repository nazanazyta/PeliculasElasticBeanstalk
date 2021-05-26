using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasElasticBeanstalk.Models
{
    [Table("peliculas")]
    public class Pelicula
    {
        [Key]
        [Column("id")]
        public int IdPelicula { get; set; }
        [Column("titulo")]
        public String Titulo { get; set; }
        [Column("genero")]
        public String Genero { get; set; }
        [Column("director")]
        public String Director { get; set; }
    }
}