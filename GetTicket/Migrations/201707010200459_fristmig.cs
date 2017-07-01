namespace GetTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fristmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventsModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PurcheEnd = c.DateTime(nullable: false),
                        Description = c.String(),
                        OwnerID = c.Int(nullable: false),
                        LogoImgUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FieldsModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventID = c.Int(nullable: false),
                        InputType = c.String(),
                        Name = c.String(),
                        EventsModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EventsModels", t => t.EventsModel_ID)
                .Index(t => t.EventsModel_ID);
            
            CreateTable(
                "dbo.TicketsModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Description = c.String(),
                        EventID = c.Int(nullable: false),
                        Events_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EventsModels", t => t.Events_ID)
                .Index(t => t.Events_ID);
            
            CreateTable(
                "dbo.PurchasesModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FieldID = c.Int(nullable: false),
                        InputFiledValue = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TicketsModels", "Events_ID", "dbo.EventsModels");
            DropForeignKey("dbo.FieldsModels", "EventsModel_ID", "dbo.EventsModels");
            DropIndex("dbo.TicketsModels", new[] { "Events_ID" });
            DropIndex("dbo.FieldsModels", new[] { "EventsModel_ID" });
            DropTable("dbo.PurchasesModels");
            DropTable("dbo.TicketsModels");
            DropTable("dbo.FieldsModels");
            DropTable("dbo.EventsModels");
        }
    }
}
