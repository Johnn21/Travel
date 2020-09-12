namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationUserPhone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "phoneUser", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "phoneUser", c => c.Int(nullable: false));
        }
    }
}
