namespace m3GenericsInterfacesAttributes.Attributes;

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