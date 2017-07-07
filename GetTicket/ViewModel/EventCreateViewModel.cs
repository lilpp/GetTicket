using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetTicket.ViewModel
{
    public class EventCreateViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Név")]
        public string Name { get; set; }
        [Display(Name = "Esemény kezdete")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Esemény vége")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Jegyárúsítás vége")]
        [DataType(DataType.Date)]
        public DateTime PurcheEnd { get; set; }
        [Display(Name = "Esemény leírása")]
        public string Description { get; set; }
        [Display(Name = "Esemény logó")]
        public string LogoImgUrl { get; set; }

        public IEnumerable<FieldViewModel> Fields { get; set; }
        public IEnumerable<TicketViewModel> Tickets { get; set; }

    }
}