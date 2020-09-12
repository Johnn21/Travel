namespace Travel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'024f0048-19f7-4cd1-9066-c486ad398363', N'guest3@travel.com', 0, N'ALQHjeepnmogIpjcBUUHIODeSEtZnGRqB1WITBrwxsbocEhRZGesEQ4KWU/QzmjIIg==', N'789609e5-3981-464d-90c8-255071fc704e', NULL, 0, 0, NULL, 1, 0, N'guest3@travel.com', 12345, N'1990-01-01 00:00:00')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'0802ef6e-57e1-4cb4-b6fd-7fc264889859', N'administrator@travel.com', 0, N'ACzgDOaqbGqIeSz+Sbu3C6nWdfUMsFxqrz4rK9+saHoRYbuz4wZV821zHOj+ZC6r/A==', N'f9ad82c0-ca61-4c44-b75f-735698aa1fed', NULL, 0, 0, NULL, 1, 0, N'administrator@travel.com', NULL, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'08805db6-ade0-42d3-97aa-4e50d4afb1dd', N'guest2@travel.com', 0, N'AF9dzVZbaYxlUJjLSOomddLjMMGn/bgNTx+3h3o07OmaRMF42bEbVd+sFzsiaEJ3pQ==', N'7c4d7ae2-fd05-42b0-b6b3-5b29738bd4cd', NULL, 0, 0, NULL, 1, 0, N'guest2@travel.com', 1234, N'1990-01-01 00:00:00')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'1fcd7102-dcbc-410f-96f3-958703d04825', N'anotherguest@travel.com', 0, N'APfapHBYJCVH+a8nJ45OHjqVrvkswHEkt7oOIMoH55Gr2rQMsucB93Vxi3hf7SE2Og==', N'6d6c8eb0-ea07-49fc-b8ae-1149fbfa8400', NULL, 0, 0, NULL, 1, 0, N'anotherguest@travel.com', 12345, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'36a402ff-2218-44d3-a41d-de0dddc8f6dd', N'guest4@travel.com', 0, N'ACyAEwJjhslZJIy88PIdj05OmGalexptzyeQrNkGp3lFnLBPn3msc7XX+0UkxxCgvQ==', N'37dc2573-cfab-4590-b2a9-f9714665e231', NULL, 0, 0, NULL, 1, 0, N'guest4@travel.com', 12345, N'1990-01-01 00:00:00')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'579216c3-6bf9-4098-a5f5-436e392850c3', N'firstuser@travel.com', 0, N'AKanjad+kAlkjZmZFAM5B4GEQ5La5311/y/f0tFSW6lrP+nS2+pe3rvkNf+rxSvgQw==', N'9aeed0d7-4f5e-4f64-ab6a-5f55f1a70619', NULL, 0, 0, NULL, 1, 0, N'firstuser@travel.com', 12345, N'1990-01-01 00:00:00')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'841321de-d9b4-4b0b-ac01-b877e79cb04b', N'admin@travel.com', 0, N'AAkPaeABG+c+U7I+67G9y9kb+fnyGaePGlDpxtdOBAJihKC47uahuTekjN18PM2krg==', N'8ed38206-545f-4516-93e2-849219f98295', NULL, 0, 0, NULL, 1, 0, N'admin@travel.com', NULL, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'8b820745-9fb2-477a-89ad-30e87a663b02', N'cata_xdr21@yahoo.com', 0, NULL, N'd63d25d7-0546-4613-88ef-9b960e317621', NULL, 0, 0, NULL, 1, 0, N'cata_xdr21@yahoo.com', 123, NULL)
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [phoneUser], [birthdateUser]) VALUES (N'bfee62d8-4b66-43ea-b7dd-8bf92d4980dc', N'guest@travel.com', 0, N'AFT34PoXIULgfz0jm3NH/F4CT6OcZdLeTfItz3RcvCqZ5jw0Z0GIDSSpQDII0sUoew==', N'e5114075-6b08-4a25-8227-ac77d5d38cd5', NULL, 0, 0, NULL, 1, 0, N'guest@travel.com', NULL, NULL)

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'150441ac-158a-4769-a2ef-477924451140', N'CanAdmin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'59978592-8f0b-492d-b4f4-e6e79dcb9aa0', N'CanMakeReview')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2872c93e-5eee-4043-90fb-9d7ed1e640c7', N'userRole')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0802ef6e-57e1-4cb4-b6fd-7fc264889859', N'150441ac-158a-4769-a2ef-477924451140')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'579216c3-6bf9-4098-a5f5-436e392850c3', N'2872c93e-5eee-4043-90fb-9d7ed1e640c7')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'841321de-d9b4-4b0b-ac01-b877e79cb04b', N'59978592-8f0b-492d-b4f4-e6e79dcb9aa0')

");
        }
        
        public override void Down()
        {
        }
    }
}
