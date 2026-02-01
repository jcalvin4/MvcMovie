using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext( serviceProvider.GetRequiredService<
            DbContextOptions<MvcMovieContext>>()))
        {
            //Look for any movies.
            if (context.Movie.Any())
            {
                return; // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                 new Movie
                {
                    Title = "Lord of The Rings: Fellowship of the Ring",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Fantasy",
                    Price = 2.99M
                },
                 new Movie
                {
                    Title = "Lord of The Rings: The Two Towers",
                    ReleaseDate = DateTime.Parse("2002-12-18"),
                    Genre = "Fantasy",
                    Price = 2.99M
                },
                 new Movie
                {
                    Title = "Lord of The Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 2.99M
                },
                 new Movie
                {
                    Title = "Map of Tiny Perfect Things",
                    ReleaseDate = DateTime.Parse("2021-2-12"),
                    Genre = "Fantasy",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}