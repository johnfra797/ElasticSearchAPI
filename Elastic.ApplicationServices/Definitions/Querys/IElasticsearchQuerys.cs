using Elastic.Domain.DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.ApplicationServices.Definitions.Querys
{
    public interface IElasticsearchQuerys
    {
        ISearchResponse<Results> Search(Search search);
    }
}
