namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category_Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Price = c.String(nullable: false),
                        Image = c.String(),
                        C_Id = c.Int(nullable: false),
                        SellBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.C_Id, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellBy, cascadeDelete: true)
                .Index(t => t.C_Id)
                .Index(t => t.SellBy);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Seller_Name = c.String(nullable: false, maxLength: 50),
                        Shop_Name = c.String(nullable: false, maxLength: 50),
                        Seller_Email = c.String(nullable: false),
                        Seller_Password = c.String(nullable: false),
                        Seller_Address = c.String(nullable: false),
                        Seller_Phone = c.String(nullable: false),
                        Seller_JoinDate = c.DateTime(nullable: false),
                        Seller_Picture = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustId = c.Int(nullable: false, identity: true),
                        Fname = c.String(nullable: false),
                        Lname = c.String(nullable: false),
                        Phone_number = c.String(nullable: false),
                        email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        gender = c.String(nullable: false),
                        Dob = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        review = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustId);
            
            CreateTable(
                "dbo.DeliveryMen",
                c => new
                    {
                        DelId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Gender = c.String(),
                        JoinDate = c.DateTime(nullable: false),
                        Dob = c.DateTime(nullable: false),
                        Zip_Code = c.Int(nullable: false),
                        nid = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DelId);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        prompid = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        description = c.String(nullable: false),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        discount_amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.prompid);
            
            CreateTable(
                "dbo.Searches",
                c => new
                    {
                        search_Id = c.Int(nullable: false, identity: true),
                        cust_id = c.Int(nullable: false),
                        search_text = c.String(),
                    })
                .PrimaryKey(t => t.search_Id)
                .ForeignKey("dbo.Customers", t => t.cust_id, cascadeDelete: true)
                .Index(t => t.cust_id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenString = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(),
                        UserEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Searches", "cust_id", "dbo.Customers");
            DropForeignKey("dbo.Products", "SellBy", "dbo.Sellers");
            DropForeignKey("dbo.Products", "C_Id", "dbo.Categories");
            DropIndex("dbo.Searches", new[] { "cust_id" });
            DropIndex("dbo.Products", new[] { "SellBy" });
            DropIndex("dbo.Products", new[] { "C_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Tokens");
            DropTable("dbo.Searches");
            DropTable("dbo.Promotions");
            DropTable("dbo.DeliveryMen");
            DropTable("dbo.Customers");
            DropTable("dbo.Sellers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
