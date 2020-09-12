namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationToReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "locationReview", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "locationReview");
        }
    }
}
