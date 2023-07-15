using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.Dal.Entities
{
    public class ContactInfo
    {
        [Key]
        public int ContactInfoId { get; set; }
        public string ContactInfoDes { get; set; }
        public string ContactInfoPhone { get; set; }
        public string ContactInfoMail { get; set; }
        public string ContactInfoAdress { get; set; }
        public string ContactInfoMaps { get; set; }
    }
}