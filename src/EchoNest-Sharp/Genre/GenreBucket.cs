using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EchoNest.Genre
{
    [Flags]
    public enum GenreBucket
    {
        // bucket = description & bucket = urls
        [Description("description")]
        Description = 1,
        [Description("urls")]
        Urls = 2
    }
}
