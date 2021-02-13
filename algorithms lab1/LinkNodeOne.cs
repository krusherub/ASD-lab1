using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    class LinkNodeOne<T>
    {
        public T Item { get; set; }
        public LinkNodeOne<T> Next { get; set; } = null;
        public LinkNodeOne(T item)
        {
                this.Item = item;
        }
    }
}
