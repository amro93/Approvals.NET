using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class CreateAuditedEntity<TUserPK, TUser> : CreateAuditedEntity<TUserPK>, ICreateAuditedEntity<TUserPK, TUser>
        where TUser : class
    {
        public TUser? CreatedBy { get; set; }
    }

}
