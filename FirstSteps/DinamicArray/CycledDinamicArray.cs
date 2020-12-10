using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ArrayForTask

{
    public class CycledDynamicArray<T> : DynamicArray<T>
    {
        public CycledDynamicArray() : base() { }

        public CycledDynamicArray(int capacity) : base(capacity) { }

        public CycledDynamicArray(IEnumerable<T> collection) : base(collection) { }


        public override IEnumerator<T> GetEnumerator()
        {
            int position = -1;

            while (true)
            {
                position++;
                position %= length;
                yield return array[position];
            }
        }
    }

}
