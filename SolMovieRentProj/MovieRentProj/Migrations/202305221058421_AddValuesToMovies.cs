namespace MovieRentProj.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddValuesToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hangover', '1', '2022-01-01', '2009-11-06',5);");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', '2', '2022-05-01', '2005-11-06',3);");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', '3', '2022-06-01', '2004-11-06',1);");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Toy Story', '4', '2020-08-07', '2011-05-06',9);");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', '5', '2023-04-01', '1995-11-06',3);");
        }

        public override void Down()
        {
        }
    }
}
