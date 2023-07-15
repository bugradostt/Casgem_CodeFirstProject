using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.Dal.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutImgUrl1 { get; set; }
        public string AboutTitle1 { get; set; }
        public string AboutDes1 { get; set; }

        public string AboutTitle2 { get; set; }
        public string AboutDes2 { get; set; }

        public string AboutImgUrl2 { get; set; }
        public string AboutTitle3 { get; set; }
        public string AboutDes3 { get; set; }
    }
}