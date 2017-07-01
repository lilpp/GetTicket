using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTicket.Models
{
    public class EventsModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PurcheEnd { get; set; }
        public string Description { get; set; }
        public string OwnerID { get; set; }
        public string LogoImgUrl { get; set; }

        public virtual List<TicketsModel> Tickets { get; set; }
        public virtual List<FieldsModel> Fields { get; set; }
    }
}