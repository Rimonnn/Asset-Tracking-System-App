namespace AssetTrakingSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropertyproductdescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "ProductDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductCategories", "ProductDescription");
        }
    }
}
