namespace OneRepo4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RepoItems", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RepoItems", "URL");
        }
    }
}
