using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EchoNest.Genre
{
    public class List : EchoNestService
    {
        #region Fields

        private const string Url = "genre/list";

        #endregion Fields

        #region Methods

        public ListResponse Execute(ListArgument argument)
        {
            argument.ApiKey = ApiKey;
            argument.BaseUrl = Url;

            return Execute<ListResponse>(argument.ToString());
        }

        public Task<ListResponse> ExecuteAsync(ListArgument argument)
        {
            argument.ApiKey = ApiKey;
            argument.BaseUrl = Url;

            return ExecuteAsync<ListResponse>(argument.ToString());
        }

        #endregion Methods
    }
}