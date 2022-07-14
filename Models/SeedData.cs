using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MvcMovie.Controllers;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static object? Context { get; private set; }
        public static object? Movie { get; set; }

        public static void Initialize(IServiceProvider service)
        {

            using (var Context = service.GetRequiredService<IServiceScope>())
            {

                if (Context == null)
                {
                    return;
                }
                
                /*#pragma warning disable CS8602 // Dereference of a possibly null reference.*/
                object value = MvcMovieContext.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M


                    },
                    new Movie
                    {
                        Title = "GhostBusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.9M

                    },
                    new Movie
                    {
                        Title = "GhostRider",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Action Comedy",
                        Rating = "R",
                        Price = 7.99M
                    }


                    );
                Context = value;
                /* object value1 = Context.SaveChanges();*/
                /*#pragma warning restore CS8602 // Dereference of a possibly null reference.*/


            }



        }
    }
}
