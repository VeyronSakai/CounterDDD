namespace Domain
{
    /// <summary>
    /// Entity
    /// </summary>
    public sealed class Counter
    {
        private Count _count;

        public Counter()
        {
            _count = new Count(0);
        }

        public Count GetCurrentCount()
        {
            return _count;
        }

        public Count Increment()
        {
            _count = _count.Increment();
            return _count;
        }
    }
}