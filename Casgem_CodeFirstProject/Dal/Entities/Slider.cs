using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.Dal.Entities
{
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string SliderDes { get; set; }
        public string SliderImgUrl { get; set; }
    }
}