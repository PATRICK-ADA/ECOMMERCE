using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Models
{
    public class Car
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public string YearOfMan { get; set; }
        public string PlateNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string Color { get; set; }
        public string TypeOfCar { get; set; }
        public int Mileage { get; set; }
        public double Price { get; set; }
        public string UnitOfPrice { get; set; }


        //Naviagation
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Image> Images { get; set; }

        // Reference 

        public string UserId { get; set; }
        public User User { get; set; }



    }
}
