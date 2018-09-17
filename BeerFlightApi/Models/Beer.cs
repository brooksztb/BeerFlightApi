using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BeerFlightApi
{
    public class Beer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int IBU { get; set; }
        [DataMember]
        public string AlcoholContent { get; set; }
    }
}
