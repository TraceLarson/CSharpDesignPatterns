using System;

namespace EventDelegates
{
    public class SubscriberServiceOne
    {
        public void OnEventDispatched(object source, DispatchEventArgs e)
        {
            Console.WriteLine($"SubscriberServiceOne reporting in...{e.User.FirstName}");
        }
    }
}