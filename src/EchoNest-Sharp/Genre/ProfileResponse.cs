using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EchoNest.Genre
{
    [DataContract]
    public class ProfileResponse : Response
    {
        [DataMember(Name = "genres")]
        public List<GenreBucketItem> Genres { get; set; }
    }
}
