using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Genre
{
    [DataContract]
    public class ListResponse : Response
    {
        [DataMember(Name = "genres")]
        public List<GenreBucketItem> Genres { get; set; }
    }
}