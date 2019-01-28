namespace CarMechanicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discount = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNo = c.String(maxLength: 15),
                        Address = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateNo = c.String(nullable: false, maxLength: 10),
                        Brand = c.String(maxLength: 30),
                        Model = c.String(maxLength: 30),
                        Colour = c.String(maxLength: 30),
                        Year = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.ServiceOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        MechanicId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mechanics", t => t.MechanicId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.MechanicId)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Mechanics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNo = c.String(maxLength: 15),
                        Address = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceOrders", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.ServiceOrders", "MechanicId", "dbo.Mechanics");
            DropForeignKey("dbo.Vehicles", "ClientId", "dbo.Clients");
            DropIndex("dbo.ServiceOrders", new[] { "VehicleId" });
            DropIndex("dbo.ServiceOrders", new[] { "MechanicId" });
            DropIndex("dbo.Vehicles", new[] { "ClientId" });
            DropTable("dbo.Mechanics");
            DropTable("dbo.ServiceOrders");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Clients");
        }
    }
}
