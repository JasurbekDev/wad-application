namespace WAD.WebApp._7986.BookRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateBookData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Books(Title,Author,PublishedDate,GenreId)" +
                "Values('Harry Potter','Arthur Conan Doyle',26-06-1997,1)");
        }

        public override void Down()
        {
        }
    }
}
