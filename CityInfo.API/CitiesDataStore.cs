using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States." },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Swansea",
                    Description = "The one with the beach.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 3,
                            Name = "Mumbles Lighthouse",
                            Description = "A lighthouse that sits at the end of the mumbles coast." },
                        new PointOfInterestDto() {
                            Id = 4,
                            Name = "Liberty Stadium",
                            Description = "Home to Swansea City FC and the Ospreys." },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Gimcheon",
                    Description = "The one with all the best things ever.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 5,
                            Name = "Moms Touch",
                            Description = "The best chicken burgers you will ever taste in your life." },
                        new PointOfInterestDto() {
                            Id = 6,
                            Name = "Gimcheon University",
                            Description = "Home of the best  festivals in Gimcheon, see your favourite K-Pop stars every year!" },
                    }
                },
            };
        }
    }
}
