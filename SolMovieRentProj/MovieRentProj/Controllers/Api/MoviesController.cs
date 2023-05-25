using AutoMapper;
using MovieRentProj.Dtos;
using MovieRentProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace MovieRentProj.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _contex;

        public MoviesController()
        {
            _contex = new ApplicationDbContext();
        }
        public IEnumerable<MovieDto> GetMovies()
        {
            return _contex.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        //Get method for /api/movies/id

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _contex.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //Post method for api/movies

        [HttpPost]

        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _contex.Movies.Add(movie);
            _contex.SaveChanges();

            return Created(new Uri(Request.RequestUri, "/" + movie.Id), movieDto);
        }


        //Put method for /api/movies/1

        [HttpPut]

        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var movieInDb = _contex.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(movieDto, movieInDb);

            _contex.SaveChanges();
        }

        //DELETE method for /api/delete/movie/id

        public void DeleteMovie(int id)
        {
            var moveInDb = _contex.Movies.SingleOrDefault(m => m.Id == id);

            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _contex.Movies.Remove(moveInDb);
            _contex.SaveChanges();
        }
    }
}
