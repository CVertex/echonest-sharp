using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Genre
{
    public class Artists : EchoNestService
    {
        #region Fields

        private const string Url = "genre/artists";

        #endregion Fields

        #region Methods

        public ArtistsResponse Execute(ArtistsArgument argument)
        {
            argument.ApiKey = ApiKey;
            argument.BaseUrl = Url;

            return Execute<ArtistsResponse>(argument.ToString());
        }

        public Task<ArtistsResponse> ExecuteAsync(ArtistsArgument argument)
        {
            argument.ApiKey = ApiKey;
            argument.BaseUrl = Url;

            return ExecuteAsync<ArtistsResponse>(argument.ToString());
        }

        #endregion Methods
    }
}