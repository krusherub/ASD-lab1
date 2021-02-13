using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    class LinkNodeTwo<T>
    {
        public T Item { get; set; }
        public LinkNodeTwo<T> Next { get; set; } = null;
        public LinkNodeTwo<T> Prev { get; set; } = null;
        public LinkNodeTwo(T item)
        {
            this.Item = item;
        }
    }
}
