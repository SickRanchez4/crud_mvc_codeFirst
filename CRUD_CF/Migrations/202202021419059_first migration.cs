namespace CRUD_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Modeloes", "Description", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Modeloes", "Description", c => c.String(maxLength: 50));
        }
    }
}
