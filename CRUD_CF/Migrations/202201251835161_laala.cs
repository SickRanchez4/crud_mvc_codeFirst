namespace CRUD_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class laala : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Modeloes", "Description", c => c.String(maxLength: 50));
            AlterColumn("dbo.Modeloes", "File", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Modeloes", "File", c => c.Binary(nullable: false));
            AlterColumn("dbo.Modeloes", "Description", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
