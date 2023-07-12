using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.Dal.Entities
{
    public class Destination
    {
    
        public int DestinationId { get; set; }
        public string DestinationName { get; set; }
        public string DayNight { get; set; }
        public byte Capacity { get; set; }
        public string Desription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }

}