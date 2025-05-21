namespace m3GenericsInterfacesAttributes.Attributes;

public interface IValidator<Y>
{
    bool Validate(Y input);

    static Type MyType { get { return typeof(Y); } }
}