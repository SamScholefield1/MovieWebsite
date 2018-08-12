namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Action')");
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Thriller')");
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Comedy')");
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Romance')");
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Family')");
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Horror')");
        }

        public override void Down()
        {
        }
    }
}
