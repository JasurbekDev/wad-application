namespace WAD.WebApp._7986.BookRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(GenreName)Values('Horror')");
            Sql("Insert into Genres(GenreName)Values('Comedy')");
            Sql("Insert into Genres(GenreName)Values('Romance')");
        }

        public override void Down()
        {
        }
    }
}
