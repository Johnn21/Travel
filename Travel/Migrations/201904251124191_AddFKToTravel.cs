namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKToTravel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Travels", "idUser", c => c.Int(nullable: false));
            CreateIndex("dbo.Travels", "idUser");
            AddForeignKey("dbo.Travels", "idUser", "dbo.Users", "idUser", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Travels", "idUser", "dbo.Users");
            DropIndex("dbo.Travels", new[] { "idUser" });
            DropColumn("dbo.Travels", "idUser");
        }
    }
}
