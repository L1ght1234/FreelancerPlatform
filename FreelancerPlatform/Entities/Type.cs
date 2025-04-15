using CSharpFunctionalExtensions;

namespace FreelancerPlatform.Entities;

public class Type : ValueObject
{
    public static readonly Type Deposit = new(nameof(Deposit));
    public static readonly Type Payment = new(nameof(Payment));
    public static readonly Type Withdrawal = new(nameof(Withdrawal));
    private static readonly Type[] _all = [Deposit, Payment, Withdrawal];
    public string Value {get; set;}

    public Type(string value)
    {
        Value = value;
    }

    public static Result<Type> Create(string input)
    {
        return new Type(input);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}