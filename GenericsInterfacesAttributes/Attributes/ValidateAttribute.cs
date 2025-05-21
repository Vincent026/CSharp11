namespace m3GenericsInterfacesAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ValidateAttribute<T, U> : Attribute
    where T : IValidator<U>
{
    public T Validator { get; }
}

