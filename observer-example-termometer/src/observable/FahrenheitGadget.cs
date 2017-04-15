using observer_example_termometer.src.subject;
using System;

namespace observer_example_termometer.src.observable
{
    internal class FahrenheitGadget : Observer
    {
        public FahrenheitGadget(TermometerSubject ts)
        {
            base.Subject = ts;
            base.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("\tFahrenheit observer: {0}", base.Subject.GetTemp() * 1.8 + 32);
        }
    }
}
