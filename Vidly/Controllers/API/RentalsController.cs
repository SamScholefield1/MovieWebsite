using System;
using System.Data.Entity;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class RentalsController : ApiController
    {

        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }


        //GET /api/rentals
        public IEnumerable<RentalDto> GetRentals()
        {
            return _context.Rentals
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);
        }

        //GET /api/rentals/1
        public IHttpActionResult GetRentals(int id)
        {
            var rentals = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentals == null)
                return NotFound();

            return Ok(Mapper.Map<Rental, RentalDto>(rentals));
        }

        //POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var rental = Mapper.Map<RentalDto, Rental>(rentalDto);
            _context.Rentals.Add(rental);
            _context.SaveChanges();

            rentalDto.Id = rental.Id;

            return Created(new Uri(Request.RequestUri + "/" + rental.Id), rentalDto);
        }

        //PUT /api/rental/1
        [HttpPut]
        public void UpdateRental(int id, RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(rentalDto, rentalInDb);

            _context.SaveChanges();
        }

        //DELETE /api/movies/1
        [HttpDelete]
        public void DeleteRental(int id)
        {
            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Rentals.Remove(rentalInDb);
            _context.SaveChanges();
        }
    }
}