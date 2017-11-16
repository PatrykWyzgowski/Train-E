using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train_E.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public User Passenger { get; set; }

        public virtual int CarId { get; set; }
    }
}