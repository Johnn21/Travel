namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeFKToReview : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "reviewerId", "dbo.Reviewers");
            DropForeignKey("dbo.Reviews", "idTravel", "dbo.Travels");
            DropIndex("dbo.Reviews", new[] { "idTravel" });
            DropIndex("dbo.Reviews", new[] { "reviewerId" });
            DropColumn("dbo.Reviews", "idTravel");
            DropColumn("dbo.Reviews", "reviewerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "reviewerId", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "idTravel", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "reviewerId");
            CreateIndex("dbo.Reviews", "idTravel");
            AddForeignKey("dbo.Reviews", "idTravel", "dbo.Travels", "idTravel", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "reviewerId", "dbo.Reviewers", "reviewerId", cascadeDelete: true);
        }
    }
}
