using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

public interface IValidator
{
    abstract bool ValidateInstance(MapPoint mp);

    PropertyInfo PI { get; set; }
}