namespace MovieRentProj.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SetDateofBirthToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth = '1990-03-03' WHERE id = 1;");
        }

        public override void Down()
        {
        }
    }
}
