namespace IdentityMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtodolistmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_T_ToDoList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "ToDoList_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "ToDoList_Id");
            AddForeignKey("dbo.AspNetUsers", "ToDoList_Id", "dbo.TB_T_ToDoList", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "ToDoList_Id", "dbo.TB_T_ToDoList");
            DropIndex("dbo.AspNetUsers", new[] { "ToDoList_Id" });
            DropColumn("dbo.AspNetUsers", "ToDoList_Id");
            DropTable("dbo.TB_T_ToDoList");
        }
    }
}
