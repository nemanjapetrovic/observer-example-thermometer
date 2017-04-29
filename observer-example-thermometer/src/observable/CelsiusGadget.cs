using observer_example_thermometer.src.subject;
using System;

namespace observer_example_thermometer.src.observable
{
    internal class CelsiusGadget : Observer
    {
        public CelsiusGadget(ThermometerSubject ts)
        {
            base.Subject = ts;
            base.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"\tCelsius observer: {base.Subject.GetTemp()}");
        }
    }
}
