namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1990-01-06' AS DATETIME) WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
