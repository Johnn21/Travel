namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToReview : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "nameReview", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Reviews", "locationReview", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "locationReview", c => c.String());
            AlterColumn("dbo.Reviews", "nameReview", c => c.String());
        }
    }
}
