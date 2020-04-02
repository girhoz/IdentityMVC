namespace IdentityMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_M_Supplier", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.TB_M_Supplier", new[] { "Id" });
            DropTable("dbo.TB_M_Supplier");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TB_M_Supplier",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.TB_M_Supplier", "Id");
            AddForeignKey("dbo.TB_M_Supplier", "Id", "dbo.AspNetUsers", "Id");
        }
    }
}
