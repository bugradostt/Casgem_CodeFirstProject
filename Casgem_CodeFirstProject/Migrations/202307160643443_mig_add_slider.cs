namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_slider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        SliderTitle = c.String(),
                        SliderDes = c.String(),
                        SliderImgUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
        }
    }
}
