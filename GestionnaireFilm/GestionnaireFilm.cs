using GestionnaireFilm.Entities;
using GestionnaireFilm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireFilm
{
    public partial class GestionnaireFilm : Form
    {
        public GestionnaireFilm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            CmbLang.DisplayMember = "Text";
            CmbLang.ValueMember = "Value";
            List<object> langues = new List<object>()
            {

                new { Text = "Français", Value = "fr-FR"},
                new { Text = "Anglais", Value = "en-UK" },
                
            };

            CmbLang.DataSource = langues;

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo(CmbLang.SelectedValue.ToString());
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            
            BtnADD.Text = Resources.T_BTN_AJOUTER;
            //BtnFilm.Text = Resources.T_BTN_Film;
            //checkBoxFilm.Text = Resources.T_BTN_checkFilm;
            //checkBoxRealisateur.Text = Resources.T_BTN_checkRealisateur;
            //checkBoxProducteur.Text = Resources.T_BTN_checkProducteur;
            //checkBoxActeur.Text = Resources.T_BTN_checkActeur;
           
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            using (FilmContext context = new FilmContext())
            {
                Console.WriteLine("Donner le titre du film , son genre, le studio de production et enfin l'année de sortie du film "); 
                Film film = new Film
                {
                    
                    Titre = Console.ReadLine(),
                    Genre=Console.ReadLine(), 
                    StudioProduction=Console.ReadLine(),

                };
                context.Films.Add(film);
                context.SaveChanges();
            }

            
        }
    }
}
