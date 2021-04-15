using Elastic.Data.Definitions;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.Data.Implementations
{
    public class HttpRequestContext : IHttpRequestContext
    {
        public Uri Node { get; set; }
        public ConnectionSettings connection { get; set; }
        public ElasticClient ElasticClient { get; set; }
        public HttpRequestContext()
        {
            Node = new Uri("http://localhost:9200/");
            connection = new ConnectionSettings(Node);

            ElasticClient = new ElasticClient(connection);

        }

    }
}
