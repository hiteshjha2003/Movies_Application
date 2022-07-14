// GET: Movies

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
#pragma warning disable CS8321 // Local function is declared but never used
public async Task<IActionResult> Index(_context _context, string movieGenre, string searchString, _context _context)
{
    // Use LINQ to get list of genres.
    IQueryable<string> genreQuery = from m in _context.Movie
                                    orderby m.Genre
                                    select m.Genre;
    var movies = from m in _context.Movie
                 select m;
    if (!string.IsNullOrEmpty(searchString))
    {
        movies = movies.Where(s => s.Title.Contains(searchString));
    }
    if (!string.IsNullOrEmpty(movieGenre))
    {
        movies = movies.Where(x => x.Genre == movieGenre);
    }
    var movieGenreVM = new MovieGenreViewModel
    {
        Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
        Movies = await movies.ToListAsync()
    };
    return View(movieGenreVM);
}
#pragma warning restore CS8321 // Local function is declared but never used
#pragma warning disable IDE0061 // Use block body for local functions
[Bind("Id,Title,ReleaseDate,Genre,Price,Rating")]
IActionResult View(MovieGenreViewModel movieGenreVM) => throw new NotImplementedException();
#pragma warning restore IDE0061 // Use block body for local functions

