using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Services.Seeding
{
    public interface ISeedService
    {
        public float Order { get; }
        Task SeedAsync();
    }
}
