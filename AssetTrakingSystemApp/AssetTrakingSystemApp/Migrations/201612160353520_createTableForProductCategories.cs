namespace AssetTrakingSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableForProductCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false, maxLength: 5),
                        SubCategoryId = c.Int(nullable: false),
                        CategorySetupId = c.Int(nullable: false),
                        GeneralCategoryId = c.Int(nullable: false),
                        GeneralCatagory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategorySetups", t => t.CategorySetupId)
                .ForeignKey("dbo.GeneralCatagories", t => t.GeneralCatagory_Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.CategorySetupId)
                .Index(t => t.GeneralCatagory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductCategories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.ProductCategories", "GeneralCatagory_Id", "dbo.GeneralCatagories");
            DropForeignKey("dbo.ProductCategories", "CategorySetupId", "dbo.CategorySetups");
            DropIndex("dbo.ProductCategories", new[] { "GeneralCatagory_Id" });
            DropIndex("dbo.ProductCategories", new[] { "CategorySetupId" });
            DropIndex("dbo.ProductCategories", new[] { "SubCategoryId" });
            DropTable("dbo.ProductCategories");
        }
    }
}
