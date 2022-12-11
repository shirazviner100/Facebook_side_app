using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserInterface
{
    //// Interface to observers of corona sick notifier
    public interface IObserverCoronaSick
    {
        void UpdateCoronaSick();
    }
}
