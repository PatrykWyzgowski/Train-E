using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train_E.Models
{
    public class Train
    {
        public int TrainId { get; set; }
        public string Name { get; set; }
        public List<StationTime> Timing { get; set; }
        public List<Car> Cars { get; set; }
    }
}