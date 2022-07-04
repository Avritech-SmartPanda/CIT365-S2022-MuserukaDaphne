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
                        Title = "Meet the Mormons",
                        Date = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "The Errand of Angels ",
                        Date = DateTime.Parse("2008-8-22"),
                        Genre = "Drama",
                        Rating = "R",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        Date = DateTime.Parse("2013-5-31"),
                        Genre = "Adventure",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        Date = DateTime.Parse("2011-6-03"),
                        Genre = "Adventure",
                        Rating = "R",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}