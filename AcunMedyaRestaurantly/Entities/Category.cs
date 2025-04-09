using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaRestaurantly.Entities
{
	public class Category
	{
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
       public virtual List<Product> Products { get; set; }
    }
}