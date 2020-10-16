namespace GestionnaireFilm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrmiereEtape : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Genre = c.String(),
                        Annee = c.Int(nullable: false),
                        StudioProduction = c.String(),
                        IDRealisateur = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.ParticipantFilms",
                c => new
                    {
                        ParticipantFilmId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DteNaissance = c.DateTime(nullable: false),
                        Nationnalité = c.String(),
                    })
                .PrimaryKey(t => t.ParticipantFilmId);
            
            CreateTable(
                "dbo.ParticipantFilmFilms",
                c => new
                    {
                        ParticipantFilm_ParticipantFilmId = c.Int(nullable: false),
                        Film_FilmId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ParticipantFilm_ParticipantFilmId, t.Film_FilmId })
                .ForeignKey("dbo.ParticipantFilms", t => t.ParticipantFilm_ParticipantFilmId, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_FilmId, cascadeDelete: true)
                .Index(t => t.ParticipantFilm_ParticipantFilmId)
                .Index(t => t.Film_FilmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParticipantFilmFilms", "Film_FilmId", "dbo.Films");
            DropForeignKey("dbo.ParticipantFilmFilms", "ParticipantFilm_ParticipantFilmId", "dbo.ParticipantFilms");
            DropIndex("dbo.ParticipantFilmFilms", new[] { "Film_FilmId" });
            DropIndex("dbo.ParticipantFilmFilms", new[] { "ParticipantFilm_ParticipantFilmId" });
            DropTable("dbo.ParticipantFilmFilms");
            DropTable("dbo.ParticipantFilms");
            DropTable("dbo.Films");
        }
    }
}
