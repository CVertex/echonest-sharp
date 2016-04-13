using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Genre
{
    public class SimilarGenres : EchoNestService
    {
        #region Fields

        private const string Url = "genre/similar";

        #endregion Fields

        #region Methods

        public SimilarGenresResponse Execute(SimilarGenresArgument argument)
        {
            argument.ApiKey = ApiKey;
            argument.BaseUrl = Url;

            return Execute<SimilarGenresResponse>(argument.ToString());
        }

        public Task<SimilarGenresResponse> ExecuteAsync(SimilarGenresArgument argument)
        {
            argument.ApiKey = ApiKey;
            argument.BaseUrl = Url;

            return ExecuteAsync<SimilarGenresResponse>(argument.ToString());
        }

        #endregion Methods
    }
}
