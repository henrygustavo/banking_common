using System;

namespace MoneyTransfer.Common.Domain
{
    public interface IIdentity
    {
        Guid Id { get; }
    }
}