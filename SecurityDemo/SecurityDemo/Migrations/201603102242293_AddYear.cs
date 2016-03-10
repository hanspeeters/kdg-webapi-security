namespace SecurityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Year");
        }
    }
}
