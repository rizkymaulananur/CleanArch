using CleanArch.Domain.Common;

namespace CleanArch.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
