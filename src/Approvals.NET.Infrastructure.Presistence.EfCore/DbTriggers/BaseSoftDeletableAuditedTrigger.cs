using Approvals.NET.Application.Identity.Users;
using Approvals.NET.Domain.Interfaces;
using EntityFrameworkCore.Triggered;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbTriggers
{
    public abstract class BaseSoftDeletableAuditedTrigger : IBeforeSaveTrigger<ISoftDeleteAuditedEntity<Guid?>>
    {
        private readonly ICurrentUser _authenticatedUser;

        public BaseSoftDeletableAuditedTrigger(ICurrentUser authenticatedUser)
        {
            _authenticatedUser = authenticatedUser;
        }
        public async Task BeforeSave(ITriggerContext<ISoftDeleteAuditedEntity<Guid?>> context, CancellationToken cancellationToken)
        {

            if (context.ChangeType != ChangeType.Modified ||
                !context.Entity.IsDeleted || context.UnmodifiedEntity.IsDeleted) return;
            context.Entity.DeletedById = _authenticatedUser.UserId;
        }
    }
}
