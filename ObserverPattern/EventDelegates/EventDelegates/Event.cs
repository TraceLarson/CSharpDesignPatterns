using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EventDelegates
{
    public class DispatchEventArgs : EventArgs
    {
        public User User { get; set; }
    }

    class Event
    {

        public event EventHandler<DispatchEventArgs> EventDispatched;

        public void Dispatch(User user)
        {
            Console.WriteLine("Getting Username..");
            Thread.Sleep(3000);
            OnEventDispatched(user);
        }

        protected virtual void OnEventDispatched(User user)
        {
            EventDispatched?.Invoke(this, new DispatchEventArgs() {User = user});
        }
    }
}