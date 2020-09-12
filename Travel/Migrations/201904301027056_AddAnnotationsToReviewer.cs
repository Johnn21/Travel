namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToReviewer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviewers", "userNameReviewer", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviewers", "userNameReviewer", c => c.String());
        }
    }
}
