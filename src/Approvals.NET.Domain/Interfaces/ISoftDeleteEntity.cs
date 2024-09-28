using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface ISoftDeleteEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
