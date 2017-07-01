namespace GetTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class endre : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.FieldsModels", name: "EventsModel_ID", newName: "Events_ID");
            RenameIndex(table: "dbo.FieldsModels", name: "IX_EventsModel_ID", newName: "IX_Events_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.FieldsModels", name: "IX_Events_ID", newName: "IX_EventsModel_ID");
            RenameColumn(table: "dbo.FieldsModels", name: "Events_ID", newName: "EventsModel_ID");
        }
    }
}
