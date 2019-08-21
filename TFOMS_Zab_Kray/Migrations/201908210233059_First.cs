namespace TFOMS_Zab_Kray.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "OIO.BUILDINGS",
                c => new
                    {
                        Building_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Address = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Building_Id);
            
            CreateTable(
                "OIO.CABINETS",
                c => new
                    {
                        Cabinet_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Number = c.Decimal(nullable: false, precision: 3, scale: 0),
                        DepartmentId = c.Decimal(precision: 10, scale: 0),
                        BuildingID = c.Decimal(nullable: false, precision: 10, scale: 0),
                        FloorID = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Cabinet_Id)
                .ForeignKey("OIO.BUILDINGS", t => t.BuildingID, cascadeDelete: true)
                .ForeignKey("OIO.OTDELS", t => t.DepartmentId)
                .ForeignKey("OIO.FLOORS", t => t.FloorID, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.BuildingID)
                .Index(t => t.FloorID);
            
            CreateTable(
                "OIO.OTDELS",
                c => new
                    {
                        Department_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Title = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Department_Id);
            
            CreateTable(
                "OIO.EMPLOYEES",
                c => new
                    {
                        Employee_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        FIO = c.String(),
                        DepartmentId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PositionId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Phone = c.Decimal(precision: 5, scale: 0),
                    })
                .PrimaryKey(t => t.Employee_Id)
                .ForeignKey("OIO.OTDELS", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("OIO.POSITION", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "OIO.POSITION",
                c => new
                    {
                        Position_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Position_Id);
            
            CreateTable(
                "OIO.FLOORS",
                c => new
                    {
                        Floor_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Floor_Id);
            
            CreateTable(
                "OIO.PRINTERS",
                c => new
                    {
                        Printer_Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Manufacturer = c.String(nullable: false, maxLength: 20),
                        Series = c.String(nullable: false, maxLength: 40),
                        IsClosed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        IP = c.String(maxLength: 16),
                        CabinetId = c.Decimal(precision: 10, scale: 0),
                        IsConsumable = c.Decimal(nullable: false, precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.Printer_Id)
                .ForeignKey("OIO.CABINETS", t => t.CabinetId)
                .Index(t => t.CabinetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("OIO.PRINTERS", "CabinetId", "OIO.'CABINETS'");
            DropForeignKey("OIO.CABINETS", "FloorID", "OIO.FLOORS");
            DropForeignKey("OIO.EMPLOYEES", "PositionId", "OIO.POSITION");
            DropForeignKey("OIO.EMPLOYEES", "DepartmentId", "OIO.OTDELS");
            DropForeignKey("OIO.CABINETS", "DepartmentId", "OIO.OTDELS");
            DropForeignKey("OIO.CABINETS", "BuildingID", "OIO.BUILDINGS");
            DropIndex("OIO.PRINTERS", new[] { "CabinetId" });
            DropIndex("OIO.EMPLOYEES", new[] { "PositionId" });
            DropIndex("OIO.EMPLOYEES", new[] { "DepartmentId" });
            DropIndex("OIO.CABINETS", new[] { "FloorID" });
            DropIndex("OIO.CABINETS", new[] { "BuildingID" });
            DropIndex("OIO.CABINETS", new[] { "DepartmentId" });
            DropTable("OIO.PRINTERS");
            DropTable("OIO.FLOORS");
            DropTable("OIO.POSITION");
            DropTable("OIO.EMPLOYEES");
            DropTable("OIO.OTDELS");
            DropTable("OIO.CABINETS");
            DropTable("OIO.BUILDINGS");
        }
    }
}
