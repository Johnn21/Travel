namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKToReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "idTravel", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "reviewerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "idTravel");
            CreateIndex("dbo.Reviews", "reviewerId");
            AddForeignKey("dbo.Reviews", "reviewerId", "dbo.Reviewers", "reviewerId", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "idTravel", "dbo.Travels", "idTravel", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "idTravel", "dbo.Travels");
            DropForeignKey("dbo.Reviews", "reviewerId", "dbo.Reviewers");
            DropIndex("dbo.Reviews", new[] { "reviewerId" });
            DropIndex("dbo.Reviews", new[] { "idTravel" });
            DropColumn("dbo.Reviews", "reviewerId");
            DropColumn("dbo.Reviews", "idTravel");
        }
    }
}
