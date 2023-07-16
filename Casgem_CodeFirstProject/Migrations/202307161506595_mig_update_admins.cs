namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_admins : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminStatus");
        }
    }
}
