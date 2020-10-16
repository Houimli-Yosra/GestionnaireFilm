using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireFilm.Entities
{
   public  class Film
    {

        public int FilmId { get; set; }
        
        public string Titre { get; set; }

        public string Genre { get; set; }

        public int Annee { get; set; }
       public string StudioProduction { get; set; }
      
       

       public  List<ParticipantFilm> Participants { get; set; }
   }
}
