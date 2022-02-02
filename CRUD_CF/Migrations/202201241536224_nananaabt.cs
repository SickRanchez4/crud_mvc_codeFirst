namespace CRUD_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nananaabt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Modeloes", "File");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modeloes", "File", c => c.Binary(nullable: false));
        }
    }
}
