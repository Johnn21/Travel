namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneUSer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "phoneUser", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "phoneUser");
        }
    }
}
