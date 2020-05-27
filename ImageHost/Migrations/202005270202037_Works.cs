namespace ImageHost.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Works : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(nullable: false, unicode: false),
                        DateUploaded = c.DateTime(nullable: false, precision: 0),
                        Author_Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Works", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Works", new[] { "Author_Id" });
            DropTable("dbo.Works");
        }
    }
}
