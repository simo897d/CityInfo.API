using System;
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
                Description = "Weed",
                PointsOfInterest = new List<PointOfInterestDto>(){
                new PointOfInterestDto(){
                Id = 1,
                Name = "A Bicycle",
                Description ="Der sikkert mange." 
                }
                }
            },
            new CityDto{
                Id =2,
                Name ="Copenhagen",
                Description = "Capital of Denmark",
                PointsOfInterest = new List<PointOfInterestDto>(){
                                new PointOfInterestDto(){
                Id = 1,
                Name = "Den Lille Havfrue",
                Description = "Det en havfrue."
                }
                }
            },
            new CityDto {
                Id=3,
                Name="Paris",
                Description="The one with that big tower.",
                PointsOfInterest = new List<PointOfInterestDto>(){
                                new PointOfInterestDto(){
                Id = 1,
                Name = "Eiffel Tower",
                Description = "Et fandens stort tårn. Som man ikke må tage billeder af om natten. Ellers kommer du i spjældet makker."
                }
                }
            }
            };
            
        }
    }
}
