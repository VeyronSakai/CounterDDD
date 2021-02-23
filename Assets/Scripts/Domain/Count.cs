using System;

namespace Domain
{
    /// <summary>
    /// ValueObject
    /// </summary>
    public class Count : IEquatable<Count>
    {
        public int Value { get; }

        public Count(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{typeof(Count)} cannot be less than 0");
            }

            Value = value;
        }

        public Count Increment()
        {
            return new Count(Value + 1);
        }

        public bool Equals(Count other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Count) obj);
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}