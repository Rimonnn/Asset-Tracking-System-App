namespace AssetTrakingSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForSubCtegoryInitialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false, maxLength: 5),
                        GeneralCtegoryId = c.Int(nullable: false),
                        CategorySetupId = c.Int(nullable: false),
                        GeneralCatagory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategorySetups", t => t.CategorySetupId, cascadeDelete: true)
                .ForeignKey("dbo.GeneralCatagories", t => t.GeneralCatagory_Id)
                .Index(t => t.CategorySetupId)
                .Index(t => t.GeneralCatagory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategories", "GeneralCatagory_Id", "dbo.GeneralCatagories");
            DropForeignKey("dbo.SubCategories", "CategorySetupId", "dbo.CategorySetups");
            DropIndex("dbo.SubCategories", new[] { "GeneralCatagory_Id" });
            DropIndex("dbo.SubCategories", new[] { "CategorySetupId" });
            DropTable("dbo.SubCategories");
        }
    }
}
