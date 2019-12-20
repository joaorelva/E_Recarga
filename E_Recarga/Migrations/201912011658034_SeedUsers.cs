namespace E_Recarga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5a7b7333-d308-427d-af18-ebe8d6bc99e0', N'admin@e-recarga.com', 0, N'ADmPHMPgbnn9Y9TkkLWnRk9ULBAeFUXC3vIpBc6RsrCaM6AJpyoJ7LsjNFYEkk3xbA==', N'40fec855-5349-42d7-862e-a205bf61a56b', NULL, 0, 0, NULL, 1, 0, N'admin@e-recarga.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aac3d02d-f372-4552-914a-5b239feda99d', N'guest@e-recarga.com', 0, N'AABuzmJlIwKu8TSq/l3n9PLB8NNNxaRfMuYdGbrdMZWJR/4pngjsIqIQCzXSdOQ3gw==', N'48a109cb-c16f-4f75-b23a-ebb0274565a8', NULL, 0, 0, NULL, 1, 0, N'guest@e-recarga.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'feed6342-415d-4037-af3c-f8b3dbb35a89', N'CanManagePostos')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5a7b7333-d308-427d-af18-ebe8d6bc99e0', N'feed6342-415d-4037-af3c-f8b3dbb35a89')

");
        }
        
        public override void Down()
        {
        }
    }
}
