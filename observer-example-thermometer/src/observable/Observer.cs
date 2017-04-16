using observer_example_thermometer.src.subject;

namespace observer_example_thermometer.src.observable
{
    internal abstract class Observer
    {
        protected ThermometerSubject Subject { get; set; }
        public abstract void Update();
    }
}
