namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Destination = c.String(),
                        Duration = c.String(),
                        Mail = c.String(),
                        BookingDate = c.DateTime(nullable: false),
                        BookingStatus = c.String(),
                    })
                .PrimaryKey(t => t.BookingId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Mail = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(),
                        DayNight = c.String(),
                        Capacity = c.Byte(nullable: false),
                        Desription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Guides",
                c => new
                    {
                        GuideId = c.Int(nullable: false, identity: true),
                        GuideName = c.String(),
                        GuideTitle = c.String(),
                        GuideImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GuideId);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaUrl = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Guides");
            DropTable("dbo.Destinations");
            DropTable("dbo.Contacts");
            DropTable("dbo.Bookings");
        }
    }
}
