namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercreatedBy : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ToDoes", new[] { "CreatedBy_Id" });
            DropColumn("dbo.ToDoes", "CreatedById");
            RenameColumn(table: "dbo.ToDoes", name: "CreatedBy_Id", newName: "CreatedById");
            AlterColumn("dbo.ToDoes", "CreatedById", c => c.String(maxLength: 128));
            CreateIndex("dbo.ToDoes", "CreatedById");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ToDoes", new[] { "CreatedById" });
            AlterColumn("dbo.ToDoes", "CreatedById", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ToDoes", name: "CreatedById", newName: "CreatedBy_Id");
            AddColumn("dbo.ToDoes", "CreatedById", c => c.Int(nullable: false));
            CreateIndex("dbo.ToDoes", "CreatedBy_Id");
        }
    }
}
