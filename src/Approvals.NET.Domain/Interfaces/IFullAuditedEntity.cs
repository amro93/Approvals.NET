namespace Approvals.NET.Domain.Interfaces
{
    public interface IFullAuditedEntity<TUserPK> : ITrackedEntity, ISoftDeleteAuditedEntity<TUserPK>
    {

    }
}
