using observer_example_termometer.src.subject;
using System;

namespace observer_example_termometer.src.observable
{
    internal class CelsiusGadget : Observer
    {
        public CelsiusGadget(TermometerSubject ts)
        {
            base.Subject = ts;
            base.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("\tCelsisus observer: {0}", base.Subject.GetTemp());
        }
    }
}
