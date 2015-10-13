namespace DiplomaOptions.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Birthday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "StudentId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "StudentId", c => c.String(nullable: false));
        }
    }
}
