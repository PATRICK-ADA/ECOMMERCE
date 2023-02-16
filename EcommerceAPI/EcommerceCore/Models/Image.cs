using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Models
{
    public class Image
    {
    
        public string Id { get; set; }
        
        public string ImageUrl { get; set; }
        public bool IsFeature { get; set; }
        public DateTime CreatedAt { get; set; }

        // Reference 
        public string CarId { get; set; }
        public Car Car { get; set; }
    }
}
