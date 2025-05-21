using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

internal class CityValidator : BaseValidator<string>, IValidator
{
    public bool Validate(string input)
    {
        if (!(input.ToUpper() == input))
            return false;
        if (input.Length > 20)
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

