namespace WAD.WebApp._7986.BookRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Books(Title)Values('Harry Potter')");
            Sql("Insert into Books(Author)Values('Someone')");
            Sql("Insert into Books(PublishedDate)Values('10-12-2012')");
        }
        
        public override void Down()
        {
        }
    }
}
