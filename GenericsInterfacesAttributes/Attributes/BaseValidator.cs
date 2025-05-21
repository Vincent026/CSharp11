using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

public abstract class BaseValidator<U> : IValidator
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
