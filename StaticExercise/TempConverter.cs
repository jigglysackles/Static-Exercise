namespace StaticExercise;
//The class should have at least 2 methods,
//one called FahrenheitToCelsius that will require a double as a parameter and return a double,
//the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!


public static class TempConverter
{
    public static double FahrenheitToCelsius(double temp)
    {
        var convertedVal = (temp - 32) * 5 / 9;
        return convertedVal;
    }

    public static double CelsiusToFahrenheit(double temp)
    {
        var convertedVal = (temp * 1.8) + 32;
        return convertedVal;
    }
    
    
}