using Domain;

namespace Application
{
    public sealed class CounterApplicationService
    {
        private readonly Counter _counter;
        
        public CounterApplicationService()
        {
            _counter = new Counter();
        }

        public Count GetCurrentCount()
        {
            return _counter.GetCurrentCount();
        }

        public Count CountUp()
        {
            return _counter.Increment();
        }
    }
}