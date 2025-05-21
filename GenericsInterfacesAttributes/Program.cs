using m3GenericsInterfacesAttributes.Attributes;
using m3GenericsInterfacesAttributes.StaticAbstractsInInterfaces;
using System.Numerics;
using System.Reflection;

var request = new Request();
request.DoRequest<GetRequestToSomeUrl>();

double[] doubles = new[] { 1.5, 2.1, 3.7, 4.1 };
var doubleSum = AddAll(doubles);
int[] integers = new[] { 1, 2, 3, 4, 5 };
var sum = AddAll(integers);
//Console.WriteLine(sum);

T AddAll<T>(T[] values)
    where T : INumber<T>
{
    T result = T.Zero;
    T one = T.One;
    T max = T.Max(result, one);
    T abs = T.Abs(result);

    foreach (var value in values)
        result += value;

    return result;
}


var mapPoint = new MapPoint
{
    NearestCity = "STOCKHOLM",
    GpsCoordinates = "59° 20' 4.5276'' N 18° 3' 47.6640'' E"
};

var result = ValidateMapPoint(mapPoint);

bool ValidateMapPoint(MapPoint mapPoint)
{
    var cityValidator =
        GetValidator<MapPoint, string>(nameof(mapPoint.NearestCity));
    var nearestCityResult =
        cityValidator.Validate(mapPoint.NearestCity);

    var coordinateValidator =
        GetValidator<MapPoint, string>(nameof(mapPoint.GpsCoordinates));
    var coordinateResult =
        coordinateValidator.Validate(mapPoint.GpsCoordinates);

    var p3Validator =
        GetValidator<MapPoint, int>(nameof(mapPoint.P3));
    var p3Result =
        p3Validator.Validate(mapPoint.P3);

    return nearestCityResult && coordinateResult;
}

IValidator<Y> GetValidator<T, Y>(string property)
{
    var validatorType = typeof(T)
        .GetProperty(property)
        .GetCustomAttribute(typeof(ValidateAttribute<IValidator<Y>, Y>))
        .GetType()
        .GenericTypeArguments.First();

    return Activator.CreateInstance(validatorType)
            as IValidator<Y>;
}

