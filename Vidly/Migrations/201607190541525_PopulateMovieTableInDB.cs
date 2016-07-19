namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTableInDB : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (1, 'Die Hard', 'Action')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (2, 'Crouching Tiger Hidden Dragon', 'Romance')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (3, 'Dumb & Dumber', 'Comedy')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (4, 'Bill & Ted+char(39)+s Excellent Adventure', 'Comedy')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (5, 'Scarface', 'Drama')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (6, 'Wall-E', 'Family')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (7, 'The Wizard of Oz', 'Fantasy')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (8, 'Up', 'Family')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (9, 'The Godfather', 'Drama')");
            Sql("INSERT INTO Movies (Id, Name, Genre) VALUES (10, 'Dr. Strangelove Or How I Learned to Stop Worrying and Love the Bomb', 'Science Fiction')");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
