namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieGenreColumnName : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies ADD GenreTypeId int");
        }
        
        public override void Down()
        {
            Sql("ALTER TABLE Movies DROP COLUMN Genre");
        }
    }
}
