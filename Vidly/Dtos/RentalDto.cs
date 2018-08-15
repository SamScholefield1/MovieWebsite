using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string MovieName { get; set; }
    }
}