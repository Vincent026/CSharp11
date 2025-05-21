namespace m3GenericsInterfacesAttributes.Attributes;
internal class CityValidator : IValidator<string>
{
    public bool Validate(string input)
    {
        if (!(input.ToUpper() == input))
            return false;
        if (input.Length > 20)
            return false;

        return true;
    }
}

