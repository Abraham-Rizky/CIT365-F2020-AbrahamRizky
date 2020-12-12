using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Family Comedy",
                        Rating = "PG",
                        Price = 6.99M,
                        ImagePath = "theRM.jpg"
                    },

                    new Movie
                    {
                        Title = "The Errands of Angels ",
                        ReleaseDate = DateTime.Parse("2008-1-1"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 6.99M,
                        ImagePath = "theErrandsOfAngels.jpg"
                    },

                    new Movie
                    {
                        Title = "One Man's Treasure",
                        ReleaseDate = DateTime.Parse("2009-1-23"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 3.99M,
                        ImagePath = "oneMansTreasure.jpg"
                    },

                    new Movie
                    {
                        Title = "Suits on the Loose",
                        ReleaseDate = DateTime.Parse("2005-10-5"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 5.99M,
                        ImagePath = "suitsOnTheLoose.jpg"
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}