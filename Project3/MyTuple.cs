using System;

namespace myTupleApp
{
    class MyTuple
    {
        public int[] Values { get; set; }

        public MyTuple(int[] values)
        {
            Values = values;
        }

        public override string ToString()
        {
            return string.Join(", ", Values);  // Joins the values with commas
        }
    }
}
