namespace shoniz.shop.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TelephoneRenamedToCelphone : DbMigration
    {
        public override void Up()
        {
            RenameColumn("CustomerContext.Address", "Telephone", "Celphone");
        }
        
        public override void Down()
        {
        }
    }
}
