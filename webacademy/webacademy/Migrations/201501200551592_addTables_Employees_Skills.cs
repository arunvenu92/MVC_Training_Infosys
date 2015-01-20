namespace webacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTables_Employees_Skills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Desc = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
        }
    }
}
