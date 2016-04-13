using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EchoNest.Genre
{
    public class ArtistsArgument
    {
        #region Constructors

        public ArtistsArgument()
        {
        }

        #endregion Constructors

        #region Properties

        public string Name { get; set; }

        public Artist.ArtistBucket? Bucket
        {
            get;
            set;
        }

        public bool? Limit
        {
            get;
            set;
        }
        
        internal string ApiKey
        {
            get;
            set;
        }

        internal string BaseUrl
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            UriQuery query = new UriQuery(BaseUrl);
            query.Add("api_key", ApiKey);
            query.Add("format", "json");

            if (!string.IsNullOrEmpty(Name))
            {
                query.Add("name", Name);
            }

            if (Bucket.HasValue)
            {
                foreach (var bucket in Artist.ArtistBucketExtensions.GetBucketDescriptions(Bucket.Value))
                {
                    query.Add("bucket", bucket);
                }
            }

            if (Limit.HasValue)
            {
                query.Add("limit", Limit.Value.ToString().ToLower());
            }

            return query.ToString();
        }

        #endregion
    }
}