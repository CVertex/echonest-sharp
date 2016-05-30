using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Artist
{
    [DataContract]
    public class GenreItem
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
