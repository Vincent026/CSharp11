namespace m3GenericsInterfacesAttributes.Attributes;

public class CoordinateValidator : IValidator<string>
{
    public bool Validate(string input)
    {
        if (!(input.ToLower() == input))
            return false;
        if (input.Length > 100)
            return false;

        return true;
    }
}

public class P3Validator : IValidator<int>
{
    public bool Validate(int input)
    {
        if (input < 5)
            return false;

        return true;
    }
}