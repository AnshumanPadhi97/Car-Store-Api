using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CARS_Api.Data
{
    public class CarsModel
    {
        [Key]
        public int car_id { get; set; }
        public string car_name { get; set; }
        public string car_model { get; set; }
        public int car_price { get; set; }
        public string car_description { get; set; }
    }
}
