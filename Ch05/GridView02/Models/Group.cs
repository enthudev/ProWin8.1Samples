using System.Collections.Generic;

namespace GridView02.Models
{
    public class Group<TKey, TItem>
    {
        public TKey Key { get; set; }

        public IList<TItem> Items { get; set; }
    }
}