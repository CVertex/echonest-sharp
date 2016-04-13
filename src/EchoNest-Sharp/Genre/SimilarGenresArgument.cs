using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EchoNest.Genre
{
    public class SimilarGenresArgument
    {
        #region Constructors

        public SimilarGenresArgument()
        {
        }

        #endregion Constructors

        #region Properties
        
        public GenreBucket? Bucket
        {
            get;
            set;
        }
        
        public bool? Limit
        {
            get;
            set;
        }
        
        public string Name
        {
            get;
            set;
        }

        public int? Results
        {
            get;
            set;
        }

        public int? Start
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

        #endregion Properties

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
                foreach (var bucket in Bucket.Value.GetBucketDescriptions())
                {
                    query.Add("bucket", bucket);
                }
            }

            if (Limit.HasValue)
            {
                query.Add("limit", Limit.Value);
            }
            
            if (Results.HasValue)
            {
                query.Add("results", Results.Value);
            }
            
            if (Start.HasValue)
            {
                query.Add("start", Start.Value);
            }

            return query.ToString();
        }

        #endregion Methods
    }
}
