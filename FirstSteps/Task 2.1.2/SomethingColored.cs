using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public abstract class SomethingColored
    {
        public virtual string Name { get; }
        public string color;

        public SomethingColored(string color)
        {
            this.color = color;
        }

        public abstract void ShowInfo();

        public bool SameValues(params double[] values)
        {
            var x = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] != x)
                    return false;
            }

            return true;
        }
    }
}
