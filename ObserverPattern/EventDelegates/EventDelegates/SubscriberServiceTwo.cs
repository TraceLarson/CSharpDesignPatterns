using System;

namespace EventDelegates
{
    public class SubscriberServiceTwo
    {
        public void OnEventDispatched(object source, DispatchEventArgs e)
        {
            Console.WriteLine($"SubscriberServiceTwo reporting in ...{e.User.FirstName}");
        }
    }
}