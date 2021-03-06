namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersTwo : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0802ef6e-57e1-4cb4-b6fd-7fc264889859', N'administrator@travel.com', 0, N'ACzgDOaqbGqIeSz+Sbu3C6nWdfUMsFxqrz4rK9+saHoRYbuz4wZV821zHOj+ZC6r/A==', N'f9ad82c0-ca61-4c44-b75f-735698aa1fed', NULL, 0, 0, NULL, 1, 0, N'administrator@travel.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'841321de-d9b4-4b0b-ac01-b877e79cb04b', N'admin@travel.com', 0, N'AAkPaeABG+c+U7I+67G9y9kb+fnyGaePGlDpxtdOBAJihKC47uahuTekjN18PM2krg==', N'8ed38206-545f-4516-93e2-849219f98295', NULL, 0, 0, NULL, 1, 0, N'admin@travel.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bfee62d8-4b66-43ea-b7dd-8bf92d4980dc', N'guest@travel.com', 0, N'AFT34PoXIULgfz0jm3NH/F4CT6OcZdLeTfItz3RcvCqZ5jw0Z0GIDSSpQDII0sUoew==', N'e5114075-6b08-4a25-8227-ac77d5d38cd5', NULL, 0, 0, NULL, 1, 0, N'guest@travel.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'150441ac-158a-4769-a2ef-477924451140', N'CanAdmin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'59978592-8f0b-492d-b4f4-e6e79dcb9aa0', N'CanMakeReview')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0802ef6e-57e1-4cb4-b6fd-7fc264889859', N'150441ac-158a-4769-a2ef-477924451140')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'841321de-d9b4-4b0b-ac01-b877e79cb04b', N'59978592-8f0b-492d-b4f4-e6e79dcb9aa0')
");
        }
        
        public override void Down()
        {
        }
    }
}
