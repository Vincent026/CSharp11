namespace m3GenericsInterfacesAttributes.Attributes;
public class MapPoint
{
    [Validate<CityValidator>]
    public string NearestCity { get; set; }

    [Validate<CoordinateValidator>]
    public string GpsCoordinates { get; set; }

    [Validate<P3Validator>]
    public int P3 { get; set; }

    [ValidateParameter(nameof(startingPnt))]
    public int CalculateDistance(string startingPnt)
    {
        throw new NotImplementedException();
    }

}

