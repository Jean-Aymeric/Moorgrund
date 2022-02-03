using System;
using System.Collections.Generic;

namespace Moorgrund.shared {
    class Observable {
        private bool _changed;
        public bool Changed { get { return _changed; } set { _changed = value; NotifyObservers(); } }

        private List<IObserver> Observers { get; set; }

        public Observable() {
            Observers = new List<IObserver>();
            Changed = true;
        }

        public void AddObserver(IObserver observer) {
            Observers.Add(observer);
        }

        public void RemoveOberver(IObserver observer) {
            Observers.Remove(observer);
        }

        public void NotifyObservers() {
            if (Changed) {
                foreach (IObserver Observer in Observers) {
                    Observer.Notify();
                }
            }
        }
    }
}
