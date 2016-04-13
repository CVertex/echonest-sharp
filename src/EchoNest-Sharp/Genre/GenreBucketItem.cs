using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Genre
{
    public class GenreBucketItem
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "urls")]
        public Dictionary<string, string> Urls { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
