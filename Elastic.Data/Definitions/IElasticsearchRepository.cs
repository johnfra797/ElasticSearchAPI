using Elastic.Domain.DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.Data.Definitions
{
    public interface IElasticsearchRepository
    {
        ISearchResponse<Results> Search(Search search);
    }
}
