using System.Reflection;

namespace m3GenericsInterfacesAttributes.Attributes;

public interface IValidator<Y>
{
    abstract bool Validate(Y input);

    PropertyInfo PI { get; set; }   

    static Type MyType { get { return typeof(Y); } }
}