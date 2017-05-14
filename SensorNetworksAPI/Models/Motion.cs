using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorNetworksAPI.Models
{
    public class Motion
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public String Location { get; set; }
    }
}