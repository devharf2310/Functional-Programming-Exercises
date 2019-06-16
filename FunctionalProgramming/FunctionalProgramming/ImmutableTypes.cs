using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    public class ImmutableTypes<T>
    {
        public DateTime Date { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public DateTimeOffset Offset { get; set; }
        public Delegate Delegate { get; set; }
        public Guid Guid { get; set; }
        public String MyProperty { get; set; }
        public Tuple<T> Tuple { get; set; }
        public Uri Uri { get; set; }
    }
}
