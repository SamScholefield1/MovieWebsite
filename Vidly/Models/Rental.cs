using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string MovieName { get; set; }
    }
}