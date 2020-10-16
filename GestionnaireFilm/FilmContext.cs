using GestionnaireFilm.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireFilm
{
   public  class FilmContext : DbContext
    {
        
        public DbSet<Film> Films { get; set; }
        public DbSet<ParticipantFilm> ParticipantFilms { get; set; }
    }
}
