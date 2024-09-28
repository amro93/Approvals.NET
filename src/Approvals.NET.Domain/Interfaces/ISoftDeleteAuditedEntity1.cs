namespace Approvals.NET.Domain.Interfaces
{
    public interface ISoftDeleteAuditedEntity<TUserPK, TUser> : IUpdateAuditedEntity<TUserPK, TUser>, ISoftDeleteEntity, ISoftDeleteAuditedEntity<TUserPK>
        where TUser : class
    {
        public TUser DeletedBy { get; set; }
    }
}
