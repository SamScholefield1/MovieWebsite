namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenreType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieGenres", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieGenres", "Genre", c => c.Int(nullable: false));
        }
    }
}
