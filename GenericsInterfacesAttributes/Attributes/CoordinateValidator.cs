namespace m3GenericsInterfacesAttributes.Attributes;


public class CoordinateValidator : BaseValidator<string>, IValidator
{
    public bool Validate(string input)
    {
        if (!(input.ToLower() == input))
            return false;
        if (input.Length > 100)
            return false;

        return true;
    }

    public override bool ValidateInstance(MapPoint mp)
    {
        if (!base.ValidateInstance(mp))
            return false;
        if (propVal is not string)
            return false;
        {
            var strVal = (string)propVal;
            return Validate(strVal);
        }
    }
}
