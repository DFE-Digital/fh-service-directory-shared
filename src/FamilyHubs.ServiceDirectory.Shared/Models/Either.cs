namespace FamilyHubs.ServiceDirectory.Shared.Models;

//General Template to include multiple classes
public class Either<TFirst, TSecond, TThird>
{
    public TFirst First { get; set; } = default!;
    public TSecond Second { get; set; } = default!;
    public TThird Third { get; set; } = default!;

}
