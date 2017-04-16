using observer_example_thermometer.src.subject;
using System;

namespace observer_example_thermometer.src.observable
{
    internal class KelvinGadget : Observer
    {
        public KelvinGadget(ThermometerSubject ts)
        {
            base.Subject = ts;
            base.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("\tKelvin observer: {0}", base.Subject.GetTemp() + 273.15);
        }
    }
}
