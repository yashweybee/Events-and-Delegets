using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegets
{
    public delegate void EventDelegate();
    public delegate void EventHandler();
    internal class EventPractice
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        publisher.MyEvent += subscriber.HandleEvent;

            publisher.RaiseEvent();

    }

    public class Publisher
    {
        // Declare an event
        public event EventHandler MyEvent;

        // Method to raise the event
        public void RaiseEvent()
        {
            Console.WriteLine("Event is being raised.");

            // Check if there are any subscribers
            if (MyEvent != null)
            {
                // Invoke the event
                MyEvent.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public class Subscriber
    {
        // Event handler method
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled by Subscriber.");
        }
    }
}
