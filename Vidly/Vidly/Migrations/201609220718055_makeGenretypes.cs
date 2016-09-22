namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class makeGenretypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, SciFi)");
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, Comedy)");
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, Romance)");
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, Action)");
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, Animated)");
        }

        public override void Down()
        {
        }
    }
}
