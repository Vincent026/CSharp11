using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

public interface IValidator<Y>
{
    abstract bool ValidateInstance(MapPoint mp);

    PropertyInfo PI { get; set; }
}