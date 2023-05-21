namespace MovieRentProj.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    Name = c.String(nullable: false, maxLength: 255),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);

            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropColumn("dbo.Movies", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
