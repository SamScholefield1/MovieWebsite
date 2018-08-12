namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
           // DropForeignKey("dbo.Movies", "MovieGenre_Id_Id", "dbo.MovieGenres");
            //DropIndex("dbo.Movies", new[] { "MovieGenre_Id_Id" });
            //DropColumn("dbo.Movies", "MovieGenre_Id_Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Movies", "MovieGenre_Id_Id", c => c.Int());
            //CreateIndex("dbo.Movies", "MovieGenre_Id_Id");
            //AddForeignKey("dbo.Movies", "MovieGenre_Id_Id", "dbo.MovieGenres", "Id");
        }
    }
}
