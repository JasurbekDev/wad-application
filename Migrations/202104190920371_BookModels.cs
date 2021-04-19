namespace WAD.WebApp._7986.BookRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "PublishedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "PublishedDate", c => c.DateTime(nullable: false));
        }
    }
}
