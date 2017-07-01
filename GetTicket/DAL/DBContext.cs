using GetTicket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GetTicket.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DBContext") { }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<EventsModel> EventModels { get; set; }
        public DbSet<TicketsModel> TicketsModels { get; set; }
        public DbSet<FieldsModel> FieldsModels { get; set; }
        public DbSet<PurchasesModel> PurchasesModels { get; set; }
    }
}