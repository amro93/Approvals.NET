namespace Approvals.NET.Domain.Interfaces
{
    public interface IFullAuditedEntity<TUserPK, TUser> : IFullAuditedEntity<TUserPK>, ISoftDeleteAuditedEntity<TUserPK, TUser>
        where TUser : class
    {

    }
}
