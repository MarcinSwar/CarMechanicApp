namespace CarMechanicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableEnddate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ServiceOrders", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ServiceOrders", "EndDate", c => c.DateTime(nullable: false));
        }
    }
}
