namespace GetTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class endre1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventsModels", "OwnerID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventsModels", "OwnerID", c => c.Int(nullable: false));
        }
    }
}
