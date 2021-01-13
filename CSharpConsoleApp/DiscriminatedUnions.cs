using System;

namespace CSharpConsoleApp
{
    public class DiscriminatedUnions
    {
        public interface ITemperature { }

        public record Celsius(double Value) : ITemperature;

        public record Fahrenheit(int Value) : ITemperature;

        public bool IsItWarm(ITemperature temperature)
        {
            return
                temperature switch
                {
                    Celsius { Value: > 25.0 } => true,
                    Fahrenheit { Value: > 77 } => true,
                    _ => false
                };
        }

        public string GetMeasure(ITemperature temperature)
        {
            return
                temperature switch
                {
                    Celsius => "Celsius",
                    Fahrenheit => "Fahrenheit",
                    _ => throw new Exception("will never happen, until we add a new variant")
                };
        }
    }
}