namespace m3GenericsInterfacesAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ValidateAttribute<T> : Attribute
{
    public T Validator { get; }
}

