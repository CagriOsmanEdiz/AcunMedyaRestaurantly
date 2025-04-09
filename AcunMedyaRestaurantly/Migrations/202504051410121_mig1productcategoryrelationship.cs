 namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1productcategoryrelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Product_ProductId", c => c.Int());
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "Product_ProductId");
            AddForeignKey("dbo.Products", "Product_ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Product_ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropColumn("dbo.Products", "Product_ProductId");
            DropColumn("dbo.Products", "CategoryId");
        }
    }
}
