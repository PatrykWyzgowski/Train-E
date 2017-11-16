using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train_E.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public bool IsOpenLayout { get; set; }
        public List<Seat> Seats { get; set; }

        public virtual Train TrainId { get; set; }
    }
}