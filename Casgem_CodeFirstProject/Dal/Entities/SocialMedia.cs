using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.Dal.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaUrl { get; set; }

        public int GuideId { get; set; }
        public  Guide Guide { get; set; }
  
    }
}