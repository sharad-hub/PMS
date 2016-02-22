namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedteamtable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "UpdatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "UpdatedBy", c => c.DateTime(nullable: false));
        }
    }
}
