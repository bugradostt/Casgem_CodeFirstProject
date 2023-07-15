namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_contactinfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        ContactInfoId = c.Int(nullable: false, identity: true),
                        ContactInfoDes = c.String(),
                        ContactInfoPhone = c.String(),
                        ContactInfoMail = c.String(),
                        ContactInfoAdress = c.String(),
                        ContactInfoMaps = c.String(),
                    })
                .PrimaryKey(t => t.ContactInfoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactInfoes");
        }
    }
}
