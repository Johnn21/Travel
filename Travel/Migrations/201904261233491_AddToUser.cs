namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "userNameUser", c => c.String());
            AddColumn("dbo.Users", "passwordUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "passwordUser");
            DropColumn("dbo.Users", "userNameUser");
        }
    }
}
