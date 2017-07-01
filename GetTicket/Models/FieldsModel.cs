using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTicket.Models
{
    public class FieldsModel
    {
        public int ID { get; set; }
        public string InputType { get; set; }
        public string Name { get; set; }

        public int EventID { get; set; }
        public virtual EventsModel Events { get; set; }
    }

}