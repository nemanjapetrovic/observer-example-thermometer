using observer_example_thermometer.src.subject;
using System;

namespace observer_example_thermometer.src.observable
{
    internal class FahrenheitGadget : Observer
    {
        public FahrenheitGadget(ThermometerSubject ts)
        {
            base.Subject = ts;
            base.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"\tFahrenheit observer: {base.Subject.GetTemp() * 1.8 + 32}");
        }
    }
}
