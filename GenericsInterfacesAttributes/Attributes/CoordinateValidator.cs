using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

public abstract class BaseValidator<U> : IValidator<U>
{
    public PropertyInfo PI { get; set; } = null!;

    protected object propVal;

    public virtual bool ValidateInstance(MapPoint mp)
    {
        propVal = PI.GetValue(mp);
        if (propVal == null)
            return false;
        return true;
    }
}

internal class CityValidator : BaseValidator<string>, IValidator<string>
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

public class CoordinateValidator : BaseValidator<string>, IValidator<string>
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

public class P3Validator : BaseValidator<int>, IValidator<int>
{
    public bool Validate(int input)
    {
        if (input < 5)
            return false;

        return true;
    }

    public override bool ValidateInstance(MapPoint mp)
    {
        if (!base.ValidateInstance(mp))
            return false;
        if (propVal is not int)
            return false;
        {
            int intVal = (int)propVal;
            return Validate(intVal);
        }
    }
}