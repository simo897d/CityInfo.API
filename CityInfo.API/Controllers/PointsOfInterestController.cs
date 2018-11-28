﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers {
    [Route("api/cities")]
    public class PointsOfInterestController : Controller {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId) {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null) {
                return NotFound();
            }
            return Ok(city.PointsOfInterest);
        }
        [HttpGet("{cityId}/pointsofinterest/{pointOfInterestId}")]
        public IActionResult GetPointOfInterest(int cityId, int pointOfInterestId) {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointOfInterestId);

            if (city == null) {
                return NotFound();
            }
            if(pointOfInterest == null) {
                return NotFound();
            }
            return Ok(pointOfInterest);
        }
    }
}
