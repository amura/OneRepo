namespace OneRepo4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialiseDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RepoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RepoItems");
        }
    }
}
