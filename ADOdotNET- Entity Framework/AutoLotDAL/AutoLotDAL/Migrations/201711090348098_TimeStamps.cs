using System;
using System.Data.Entity.Migrations;

namespace AutoLotDAL.Migrations
{ 
    public partial class TimeStamps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CreditRisks", "TimeStamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Customers", "TimeStamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Orders", "TimeStamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Inventory", "TimeStamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            CreateIndex("dbo.CreditRisks", new[] { "LastName", "FirstName" }, unique: true, name: "IDX_CreditRisk_Name");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CreditRisks", "IDX_CreditRisk_Name");
            DropColumn("dbo.Inventory", "TimeStamp");
            DropColumn("dbo.Orders", "TimeStamp");
            DropColumn("dbo.Customers", "TimeStamp");
            DropColumn("dbo.CreditRisks", "TimeStamp");
        }
    }
}
