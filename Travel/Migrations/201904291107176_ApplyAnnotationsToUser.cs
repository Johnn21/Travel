namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "firstNameUser", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "lastNameUser", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "userNameUser", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "passwordUser", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "passwordUser", c => c.String());
            AlterColumn("dbo.Users", "userNameUser", c => c.String());
            AlterColumn("dbo.Users", "lastNameUser", c => c.String());
            AlterColumn("dbo.Users", "firstNameUser", c => c.String());
        }
    }
}
