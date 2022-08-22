using FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities;
using FamilyHubs.SharedKernel;
using FamilyHubs.SharedKernel.Interfaces;

namespace FamilyHubs.ServiceDirectory.Shared.Entities;

public class OpenReferralPhone : EntityBase<string>, IOpenReferralPhone, IAggregateRoot
{
    private OpenReferralPhone() { }
    public OpenReferralPhone(string id, string number)
    {
        Id = id;
        Number = number;
    }

    public string Number { get; init; } = default!;
}
