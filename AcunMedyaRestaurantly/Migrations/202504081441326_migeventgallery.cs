namespace AcunMedyaRestaurantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migeventgallery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galleries");
            DropTable("dbo.Events");
        }
    }
}
