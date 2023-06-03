namespace MovieRentProj.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'382c9de8-89ee-4bc9-a09c-9b24a771e2a8', N'test@gmail.com', 0, N'AGL3+pzTjvPXuEw/x09BTy+ffknpVe02Hm5E2e7YLaForZb6YbIFToWz9AqEpNFD8A==', N'a0b88f18-d4b5-43e0-bbf0-9f3b437ecb46', NULL, 0, 0, NULL, 1, 0, N'test@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f819d95-e406-45f3-bcef-27dd395721c8', N'admin@test.com', 0, N'AP7iyv8oNpNrAIdaywVFBSJVMvrO6LzooinLKMOLIHq9ZcuqLvKPcBoVvJYFYFmn6w==', N'cd9b6656-72c5-44ef-8aa1-92037016ab94', NULL, 0, 0, NULL, 1, 0, N'admin@test.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6c545eb4-d33c-451d-9afb-75e07c004dd8', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7f819d95-e406-45f3-bcef-27dd395721c8', N'6c545eb4-d33c-451d-9afb-75e07c004dd8')

            ");
        }

        public override void Down()
        {
        }
    }
}
