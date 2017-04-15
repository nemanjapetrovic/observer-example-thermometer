using observer_example_termometer.src.observable;
using System.Collections.Generic;

namespace observer_example_termometer.src.subject
{
    internal class TermometerSubject
    {
        private IList<Observer> observers;
        private int temperature;

        public TermometerSubject()
        {
            this.observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public int GetTemp()
        {
            return this.temperature;
        }

        public void SetTemp(int temp)
        {
            this.temperature = temp;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var o in this.observers)
            {
                o.Update();
            }
        }
    }
}
