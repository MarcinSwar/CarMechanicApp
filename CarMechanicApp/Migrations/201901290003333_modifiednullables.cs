namespace CarMechanicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiednullables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Discount", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Discount", c => c.Int(nullable: false));
        }
    }
}
