using Elastic.Data.Definitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.ApplicationServices.Definitions.Commands
{
    public class ElasticsearchCommands: IElasticsearchCommands
    {
        private readonly IElasticsearchRepository _ElasticsearchRepository;

        public ElasticsearchCommands(IElasticsearchRepository elasticsearchRepository)
        {
            _ElasticsearchRepository = elasticsearchRepository;
        }
    }
}
