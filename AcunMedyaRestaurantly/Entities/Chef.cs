using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaRestaurantly.Entities
{
	public class Chef
	{
        public int ChefId { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
        public String ImageUrl { get; set; }

    }
}