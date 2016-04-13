using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Genre
{
    public class SimilarGenresBucketItem : GenreBucketItem
    {
        [DataMember(Name = "similarity")]
        public double Similarity { get; set; }
    }
}
