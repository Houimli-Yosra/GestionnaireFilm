using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireFilm.Entities
{
  public  class ParticipantFilm
    {

        public int ParticipantFilmId { get; set; }
      
        public string Nom { get; set; }

        public string Prenom { get; set; }
        public DateTime DteNaissance { get; set; }

        public string Nationnalité { get; set; }

        public string Fonction1 = "Acteur";

        public string Fonction2 = "Realisateur";

        public string Fonction3 = "Producteur";

       public  List<Film> Films { get; set; }
    }
}
