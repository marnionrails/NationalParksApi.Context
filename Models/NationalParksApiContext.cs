using Microsoft.EntityFrameworkCore;
using System;

namespace NationalParksApi.Models
{
    public class NationalParksApiContext : DbContext
    {
        public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(new Park { ParkId = 1, Name = "Yellowstone", Region = "West", State = "Wyoming", Description = "Yellowstone National Park sits on top of a dormant volcano and is home to more geysers and hot springs than any other place on earth."},
            new Park{ ParkId = 2, Name = "Great Smokey Mountains", Region = "Southeast", State = "Tennessee", Description = "World renowned for its diversity of plant and animal life, the beauty of its ancient mountains, and the quality of its remnants of Southern Appalachian mountain culture, this is America's most visited national park." },
            new Park{ ParkId = 3, Name = "Grand Canyon", Region = "Southwest", State = "Arizona", Description = "Grand Canyon is considered one of the finest examples of arid-land erosion in the world. Incised by the Colorado River, the canyon is immense, averaging 4,000 feet deep for its entire 277 miles. It is 6,000 feet deep at its deepest point and 18 miles at its widest."},
            new Park{ ParkId = 4, Name = "Acadia", Region = "Northeast", State = "Maine", Description = "Acadia National Park protects the natural beauty of the highest rocky headlands along the Atlantic coastline of the United States, an abundance of habitats, and a rich cultural heritage."},
            new Park{ ParkId = 5, Name = "Yosemite", Region = "West", State = "California", Description = "Yosemite National Park is filled with dramatic scenery including gigantic granite domes, cliffs, rivers, creeks, high waterfalls and Giant Sequoia."});
        }
    }
} 