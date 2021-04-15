using Elastic.Data.Definitions;
using Elastic.Domain.DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.Data.Implementations
{
    public class ElasticsearchRepository : IElasticsearchRepository
    {
        public IHttpRequestContext _context { get; set; }

        public ElasticsearchRepository(IHttpRequestContext context)
        {
            _context = context;
        }
        public ISearchResponse<Results> Search(Search search)
        {
            var resultado = _context.ElasticClient.Search<Results>(s =>s
                                    .Query(qr => qr.MultiMatch(c => c.Query(search.Text)))
                                    .Size(search.TotalSize != 0 ? search.TotalSize : 100)
                                    .Highlight(hl => hl.Fields(fls => fls.Field(f => f.Text))
                                    .PreTags("<span class='resaltado'>")
                                    .PostTags("</span>").FragmentSize(300)));



            return resultado;
        }
    }
}
