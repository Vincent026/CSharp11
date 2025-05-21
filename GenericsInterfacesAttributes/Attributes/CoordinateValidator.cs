using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

public abstract class BaseValidator<U> : IValidator<U>
{
    public PropertyInfo PI { get; set; } = null!;

    public abstract bool Validate(U input);
}

internal class CityValidator : BaseValidator<string>, IValidator<string>
{
    public override bool Validate(string input)
    {
        if (!(input.ToUpper() == input))
            return false;
        if (input.Length > 20)
            return false;

        return true;
    }
}

public class CoordinateValidator : BaseValidator<string>, IValidator<string>
{
    public override bool Validate(string input)
    {
        if (!(input.ToLower() == input))
            return false;
        if (input.Length > 100)
            return false;

        return true;
    }
}

public class P3Validator : BaseValidator<int>, IValidator<int>
{
    public override bool Validate(int input)
    {
        if (input < 5)
            return false;

        return true;
    }
}