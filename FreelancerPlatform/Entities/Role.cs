using System.Net.Security;
using CSharpFunctionalExtensions;

namespace FreelancerPlatform.Entities;

public class Role : ValueObject
{
    public static readonly Role Freelancer = new(nameof(Freelancer));
    public static readonly Role Сustomer = new(nameof(Сustomer));
    private static readonly Role[] _all = [Freelancer, Сustomer];
    public string Value {get; set;}

    public Role(string value)
    {
        Value = value;
    }

    public static Result<Role> Create(string input)
    {
        return new Role(input);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}