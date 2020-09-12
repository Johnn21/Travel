namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "descriptionReview", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "descriptionReview");
        }
    }
}
