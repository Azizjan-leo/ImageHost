namespace ImageHost.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Works_Title_and_Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Works", "Title", c => c.String(unicode: false));
            AddColumn("dbo.Works", "Description", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Works", "Description");
            DropColumn("dbo.Works", "Title");
        }
    }
}
