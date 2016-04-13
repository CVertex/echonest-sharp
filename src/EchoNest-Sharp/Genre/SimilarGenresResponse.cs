using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Genre
{
    [DataContract]
    public class SimilarGenresResponse : Response
    {
        [DataMember(Name = "genres")]
        public List<SimilarGenresBucketItem> Genres { get; set; }
    }    
}
