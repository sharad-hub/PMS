namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedresourcetable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Resources", new[] { "UserInfo_Id" });
            DropColumn("dbo.Resources", "UserInfoId");
            RenameColumn(table: "dbo.Resources", name: "UserInfo_Id", newName: "UserInfoId");
            AlterColumn("dbo.Resources", "UserInfoId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Resources", "UserInfoId");
            DropColumn("dbo.Resources", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "Name", c => c.String());
            DropIndex("dbo.Resources", new[] { "UserInfoId" });
            AlterColumn("dbo.Resources", "UserInfoId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Resources", name: "UserInfoId", newName: "UserInfo_Id");
            AddColumn("dbo.Resources", "UserInfoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Resources", "UserInfo_Id");
        }
    }
}
