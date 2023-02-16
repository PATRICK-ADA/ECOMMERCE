using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Models
{
   public class Rating
   {
        public string Id { get; set; }
       
        public int Ratings { get; set; }
        public DateTime CreatedAt { get; set; }

        // Reference 
        public string CarId { get; set; }
        public Car Car { get; set; }
    }
}
