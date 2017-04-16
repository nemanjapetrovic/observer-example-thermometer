using observer_example_thermometer.src.observable;
using observer_example_thermometer.src.subject;
using System;

namespace observer_example_thermometer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating subject
            var ts = new ThermometerSubject();

            // Creating observervables
            var celsiusObs = new CelsiusGadget(ts);
            var fahrenheitObs = new FahrenheitGadget(ts);
            var kelvinObs = new KelvinGadget(ts);

            // Notify change
            Console.WriteLine("Station temperature read: {0} celsius", 10);
            Console.WriteLine("> Notify gadgets: \n");
            ts.SetTemp(10);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Station temperature read: {0} celsius", 25);
            Console.WriteLine("> Notify gadgets: \n");
            ts.SetTemp(25);
            Console.WriteLine("--------------------------");

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
