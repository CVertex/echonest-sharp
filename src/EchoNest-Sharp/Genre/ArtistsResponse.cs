using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Genre
{
    [DataContract]
    public class ArtistsResponse : Response
    {
        [DataMember(Name = "artists")]
        public List<Artist.ArtistBucketItem> Artists { get; set; }
    }
}