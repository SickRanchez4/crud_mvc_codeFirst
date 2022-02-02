namespace CRUD_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Models", newName: "Modeloes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Modeloes", newName: "Models");
        }
    }
}
