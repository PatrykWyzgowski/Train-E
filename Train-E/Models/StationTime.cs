using System;

namespace Train_E.Models
{
    public class StationTime
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departing { get; set; }

        public virtual Train TrainId { get; set; }
    }
}