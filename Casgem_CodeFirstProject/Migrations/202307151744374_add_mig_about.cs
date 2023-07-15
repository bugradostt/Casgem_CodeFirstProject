 namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_about : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutImgUrl1 = c.String(),
                        AboutTitle1 = c.String(),
                        AboutDes1 = c.String(),
                        AboutTitle2 = c.String(),
                        AboutDes2 = c.String(),
                        AboutImgUrl2 = c.String(),
                        AboutTitle3 = c.String(),
                        AboutDes3 = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
