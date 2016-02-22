namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedBy2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WorkBreakDownStructures", "CreatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkBreakDownStructures", "CreatedBy", c => c.String());
        }
    }
}
