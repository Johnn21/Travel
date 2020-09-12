namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        idReview = c.Int(nullable: false, identity: true),
                        nameReview = c.String(),
                        relevanceReview = c.Int(nullable: false),
                        overallRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idReview);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        idTravel = c.Int(nullable: false, identity: true),
                        locationTravel = c.String(),
                        descriptionTravel = c.String(),
                    })
                .PrimaryKey(t => t.idTravel);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        firstNameUser = c.String(),
                        lastNameUser = c.String(),
                        phoneUser = c.Int(nullable: false),
                        emailAddressUser = c.String(),
                    })
                .PrimaryKey(t => t.idUser);

            CreateTable(
              "dbo.Reviewers",
              c => new
              {
                  reviewerId = c.Int(nullable: false, identity: true),
                  userNameReviewer = c.String(),
                  emailAddressReviewer = c.String(),
                  passwordReviewer = c.Int(nullable: false), 
              })
              .PrimaryKey(t => t.reviewerId);
            


    }
        
        public override void Down()
        {
            DropTable("dbo.Reviewers");
            DropTable("dbo.Users");
            DropTable("dbo.Travels");
            DropTable("dbo.Reviews");
        }
    }
}
