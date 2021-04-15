using Elastic.Data.Definitions;
using Elastic.Domain.DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.ApplicationServices.Definitions.Querys
{
    public class ElasticsearchQuerys: IElasticsearchQuerys
    {
        private readonly IElasticsearchRepository _ElasticsearchRepository;

        public ElasticsearchQuerys(IElasticsearchRepository elasticsearchRepository)
        {
            _ElasticsearchRepository = elasticsearchRepository;
        }

        public ISearchResponse<Results> Search(Search search)
        {
            return _ElasticsearchRepository.Search(search);
        }
    }
}
