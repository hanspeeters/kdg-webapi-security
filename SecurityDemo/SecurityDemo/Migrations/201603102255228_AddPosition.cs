namespace SecurityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPosition : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Division", c => c.String());

            Sql("UPDATE dbo.Teams SET Division = 'Vierde provinciaal'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Division");
        }
    }
}
