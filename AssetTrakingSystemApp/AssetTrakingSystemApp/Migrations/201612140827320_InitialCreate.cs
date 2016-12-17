namespace AssetTrakingSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false, maxLength: 5),
                        OrganaizationBranchId = c.Int(nullable: false),
                        OrganigationId = c.Int(nullable: false),
                        Organization_Id = c.Int(),
                        OrganizationBranch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.OrganizationBranches", t => t.OrganizationBranch_Id)
                .Index(t => t.Organization_Id)
                .Index(t => t.OrganizationBranch_Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(nullable: false, maxLength: 3),
                        Location = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrganizationBranches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrganizationBranches", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.AssetLocations", "OrganizationBranch_Id", "dbo.OrganizationBranches");
            DropForeignKey("dbo.AssetLocations", "Organization_Id", "dbo.Organizations");
            DropIndex("dbo.OrganizationBranches", new[] { "OrganizationId" });
            DropIndex("dbo.AssetLocations", new[] { "OrganizationBranch_Id" });
            DropIndex("dbo.AssetLocations", new[] { "Organization_Id" });
            DropTable("dbo.OrganizationBranches");
            DropTable("dbo.Organizations");
            DropTable("dbo.AssetLocations");
        }
    }
}
