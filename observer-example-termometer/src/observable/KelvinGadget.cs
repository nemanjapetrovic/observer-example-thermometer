using observer_example_termometer.src.subject;
using System;

namespace observer_example_termometer.src.observable
{
    internal class KelvinGadget : Observer
    {
        public KelvinGadget(TermometerSubject ts)
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
