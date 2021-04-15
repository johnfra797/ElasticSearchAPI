using System;
using System.Collections.Generic;
using System.Text;

namespace Elastic.Domain.DTO
{
    public class Search
    {
        public string Text { get; set; }
        public int TotalSize { get; set; }
    }
}
