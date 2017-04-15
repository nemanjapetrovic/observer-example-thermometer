using observer_example_termometer.src.subject;

namespace observer_example_termometer.src.observable
{
    internal abstract class Observer
    {
        protected TermometerSubject Subject { get; set; }
        public abstract void Update();
    }
}
