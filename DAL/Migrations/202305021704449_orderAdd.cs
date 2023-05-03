namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        Order_Date = c.DateTime(nullable: false),
                        quantity = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                        total_price = c.Int(nullable: false),
                        status = c.String(nullable: false),
                        custId = c.Int(nullable: false),
                        DelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.orderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
