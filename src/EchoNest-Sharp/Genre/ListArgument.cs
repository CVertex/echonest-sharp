using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EchoNest.Genre
{
    public class ListArgument
    {
        #region Constructors

        public ListArgument()
        {
        }

        #endregion Constructors

        #region Properties
        
        public GenreBucket? Bucket
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
            
            if (Bucket.HasValue)
            {
                foreach (var bucket in Bucket.Value.GetBucketDescriptions())
                {
                    query.Add("bucket", bucket);
                }
            }
            
            query.Add("start", 0.ToString());
            query.Add("results", 2000.ToString());
            return query.ToString();
        }

        #endregion
    }
}