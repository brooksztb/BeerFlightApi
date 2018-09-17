using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BeerFlightApi.Models
{
    public class Brewery
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public List<double> Coords { get; set; }
        [DataMember]
        public List<Beer> Beers { get; set; }
    }
}
