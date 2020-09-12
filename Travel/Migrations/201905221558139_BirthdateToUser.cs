namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthdateToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "birthdateUser", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "birthdateUser");
        }
    }
}
