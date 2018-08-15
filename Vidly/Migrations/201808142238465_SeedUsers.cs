namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ab6146ce-9f73-47f1-86f8-ba3d6f4b31c4', N'guest@vidly.com', 0, N'ACXNxx6a6Re/+6qIzkQ4aSd4dQnv/Gq30OV1m5JRLwrrQu6mAur8lFQ39xi9cmThpw==', N'01c792b4-b31b-438e-a874-fea6daa3afe1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd4732ce1-685f-491c-befa-4c23a2b06e9f', N'admin@vidly.com', 0, N'AM3JrQgGuO6wEl8QMX/uSS0p09pi/IbF+8caG+s2YEpAMRgWWJO9mzACYhmnGMd3BA==', N'1de55aa5-60cb-413e-bbc9-d543002fcfff', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e5484208-92d1-4322-9dad-887889041e28', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd4732ce1-685f-491c-befa-4c23a2b06e9f', N'e5484208-92d1-4322-9dad-887889041e28')

");
        }
        
        public override void Down()
        {
        }
    }
}
