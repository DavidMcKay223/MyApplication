using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Common
{
    public abstract class AbstractSearchDto<TSortBy, TSortOrder>
        where TSortBy : Enum
        where TSortOrder : Enum
    {
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public Boolean UsePagination { get; set; } = true;
        public TSortBy? SortBy { get; set; }
        public TSortOrder? SortOrder { get; set; }
        public int TotalItems { get; set; }
    }
}
