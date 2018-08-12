namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieGenreId", c => c.Byte(nullable: false));
            AddForeignKey("dbo.Movies", "MovieGenreId", "dbo.MovieGenres", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
