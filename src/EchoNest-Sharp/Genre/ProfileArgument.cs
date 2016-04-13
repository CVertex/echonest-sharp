using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EchoNest.Genre
{
    public class ProfileArgument
    {
        #region Constructors

        public ProfileArgument()
        {
        }

        #endregion Constructors

        #region Properties
        
        public string Name { get; set; }

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
                foreach (var bucket in Bucket.Value.GetBucketDescriptions())
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
