using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTicket.ViewModel
{
    public class EventsIndexViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}