using Approvals.NET.Application.Date;
using Approvals.NET.Application.Identity.Tenants;
using Approvals.NET.Application.Identity.Users;
using Approvals.NET.Domain.Interfaces;
using Approvals.NET.Infrastructure.Presistence.EfCore.DbTriggers;
using EntityFrameworkCore.Triggered;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Triggers
{
    public class UpdateAuditedEntityTrigger : BaseUpdateAuditedEntityTrigger, IBeforeSaveTrigger<IUpdateAuditedEntity<Guid?>>
    {
        public UpdateAuditedEntityTrigger(ICurrentUser userService, ICurrentTenant currentTenant, IDateTimeService dateTimeService, ApplicationDbContext dbContext) : base(userService, currentTenant, dateTimeService, dbContext)
        {
        }
    }

    public class CreationAuditedEntityTrigger : BaseCreationAuditedEntityTrigger, IBeforeSaveTrigger<ICreateAuditedEntity<Guid?>>, IBeforeSaveTrigger<IMayHaveTenant>, IBeforeSaveTrigger<IHaveTenant>
    {
        public CreationAuditedEntityTrigger(ICurrentUser userService, ICurrentTenant currentTenant, IDateTimeService dateTimeService) : base(userService, currentTenant, dateTimeService)
        {
        }
    }

    public class SoftDeletableAuditedTrigger : BaseSoftDeletableAuditedTrigger, IBeforeSaveTrigger<ISoftDeleteAuditedEntity<Guid?>>
    {
        public SoftDeletableAuditedTrigger(ICurrentUser authenticatedUser) : base(authenticatedUser)
        {
        }
    }

    public class SoftDeletableTrigger : BaseSoftDeletableTrigger, IBeforeSaveTrigger<ISoftDeleteEntity>
    {
        public SoftDeletableTrigger(IDateTimeService dateTimeService) : base(dateTimeService)
        {
        }
    }

    public class TrackedAuditedEntityTrigger : BaseTrackedAuditedEntityTrigger, IBeforeSaveTrigger<ITrackedEntity>
    {
        public TrackedAuditedEntityTrigger(ICurrentUser currentUser, IDateTimeService dateTimeService, ApplicationDbContext dbContext, ApplicationDbContext trackingContext) : base(currentUser, dateTimeService, dbContext, trackingContext)
        {
        }
    }
}
