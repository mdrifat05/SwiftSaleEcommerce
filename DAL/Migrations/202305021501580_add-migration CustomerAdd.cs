namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationCustomerAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customer_id = c.Int(nullable: false, identity: true),
                        first_name = c.String(nullable: false, maxLength: 100),
                        last_name = c.String(nullable: false, maxLength: 100),
                        phone_number = c.String(nullable: false, maxLength: 14),
                        email = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false, maxLength: 100),
                        gender = c.String(nullable: false, maxLength: 6),
                        dob = c.DateTime(nullable: false),
                        address = c.String(nullable: false, maxLength: 100),
                        picture = c.String(),
                        review = c.String(),
                    })
                .PrimaryKey(t => t.customer_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
