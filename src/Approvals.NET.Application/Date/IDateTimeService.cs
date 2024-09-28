using System;
using System.Collections.Generic;
using System.Text;

namespace Approvals.NET.Application.Date
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
