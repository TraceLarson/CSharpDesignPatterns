namespace EventDelegates
{
    class Program
    {

        static void Main(string[] args)
        {
            var user1 = new User("Trace");
            var user2 = new User("Tiffiny");
            var eventDispatch = new Event();
            var firstSubscriber = new SubscriberServiceOne();
            var secondSubscriber = new SubscriberServiceTwo();

            eventDispatch.EventDispatched += firstSubscriber.OnEventDispatched;
            eventDispatch.EventDispatched += secondSubscriber.OnEventDispatched;

            eventDispatch.Dispatch(user1);
            eventDispatch.Dispatch(user2);

        }
    }
}