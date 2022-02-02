namespace CRUD_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shingeki : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modeloes", "FileSize", c => c.Int(nullable: false));
            AddColumn("dbo.Modeloes", "FileName", c => c.String());
            AddColumn("dbo.Modeloes", "FileData", c => c.Binary());
            AddColumn("dbo.Modeloes", "File", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modeloes", "File");
            DropColumn("dbo.Modeloes", "FileData");
            DropColumn("dbo.Modeloes", "FileName");
            DropColumn("dbo.Modeloes", "FileSize");
        }
    }
}
