﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API {
    public class CitiesDataStore {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore() {

            Cities = new List<CityDto>() {
            new CityDto{
                Id =1,
                Name ="Amsterdam",
                Description = "Weed"
            },
            new CityDto{
                Id =2,
                Name ="Copenhagen",
                Description = "Capital of Denmark"
            },
            new CityDto {
                Id=3,
                Name="Paris",
                Description="The one with that big tower"
            }
            };
            
        }
    }
}
