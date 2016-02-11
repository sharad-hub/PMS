namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minorchange1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedOn", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "DOB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "DOB", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
