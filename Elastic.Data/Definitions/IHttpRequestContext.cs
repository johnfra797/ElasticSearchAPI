using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.Data.Definitions
{
    public interface IHttpRequestContext
    {
        Uri Node { get; set; }
        ConnectionSettings connection { get; set; }
        ElasticClient ElasticClient { get; set; }
    }
}