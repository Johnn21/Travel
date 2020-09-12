namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUser : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Users(firstNameUser,lastNameUser,phoneUser,emailAddressUser) VALUES ('nameuser1','lastnamenameuser1',1231,'emailuser@one')");
            Sql("Insert into Users(firstNameUser,lastNameUser,phoneUser,emailAddressUser) VALUES ('nameuser2','lastnamenameuser2',1232,'emailuser@two')");
        }
        
        public override void Down()
        {
        }
    }
}
