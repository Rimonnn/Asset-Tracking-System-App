namespace AssetTrakingSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorySetupPurpose : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategorySetups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false, maxLength: 5),
                        GeneralCategoryId = c.Int(nullable: false),
                        GeneralCatagory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GeneralCatagories", t => t.GeneralCatagory_Id)
                .Index(t => t.GeneralCatagory_Id);
            
            CreateTable(
                "dbo.GeneralCatagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategorySetups", "GeneralCatagory_Id", "dbo.GeneralCatagories");
            DropIndex("dbo.CategorySetups", new[] { "GeneralCatagory_Id" });
            DropTable("dbo.GeneralCatagories");
            DropTable("dbo.CategorySetups");
        }
    }
}
