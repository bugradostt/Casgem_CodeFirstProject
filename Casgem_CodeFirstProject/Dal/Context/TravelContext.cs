﻿using Casgem_CodeFirstProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.Dal.Context
{
    public class TravelContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations  { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}