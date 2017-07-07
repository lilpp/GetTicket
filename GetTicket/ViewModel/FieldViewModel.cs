using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetTicket.ViewModel
{
    public class FieldViewModel
    {
        public int ID { get; set; }
        public InputType InputType { get; set; }
        public string Name { get; set; }
    }
    
}