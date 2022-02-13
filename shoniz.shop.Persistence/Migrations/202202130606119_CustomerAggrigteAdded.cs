namespace shoniz.shop.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAggrigteAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CustomerContext.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PostalCode = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        AddressLine = c.String(nullable: false, maxLength: 500),
                        CityId = c.Int(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        Telephone = c.String(maxLength: 20),
                        Coordinate = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("CustomerContext.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "CustomerContext.Customer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NationalCode = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 4000),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            CreateTable(
                "Basic.City",
                c => new 
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        StateId = c.Int(nullable: false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Basic.State", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);

            CreateTable(
                "Basic.State",
                c => new 
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20)
                    })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            DropForeignKey("CustomerContext.Address", "CustomerId", "CustomerContext.Customer");
            DropIndex("CustomerContext.Address", new[] { "CustomerId" });
            DropTable("CustomerContext.Customer");
            DropTable("CustomerContext.Address");
        }
    }
}
