namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedisProjectTypeId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Projects", name: "ProjectType_Id", newName: "ProjectTypeId");
            RenameIndex(table: "dbo.Projects", name: "IX_ProjectType_Id", newName: "IX_ProjectTypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Projects", name: "IX_ProjectTypeId", newName: "IX_ProjectType_Id");
            RenameColumn(table: "dbo.Projects", name: "ProjectTypeId", newName: "ProjectType_Id");
        }
    }
}
