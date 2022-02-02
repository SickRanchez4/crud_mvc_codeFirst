namespace CRUD_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testarudo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Modeloes", "File", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Modeloes", "File", c => c.Binary());
        }
    }
}
