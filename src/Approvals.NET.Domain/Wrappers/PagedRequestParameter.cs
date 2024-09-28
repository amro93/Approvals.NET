using System;
using System.Collections.Generic;
using System.Text;

namespace Approvals.NET.Domain.Wrappers
{
    public class PagedRequestParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PagedRequestParameter()
        {
            PageNumber = 1;
            PageSize = 10;
        }
        public PagedRequestParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 10 ? 10 : pageSize;
        }

        public int GetSkip()
        {
            return PageNumber - 1 * PageSize;
        }

        public int GetTake()
        {
            return PageSize;
        }
    }
}
