using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeft_01
{
    public class LinkedStructure
    {
        public string[] stack = new string[0];
        int stackLength = 0;

        Dictionary<string, int> map = new Dictionary<string, int>();

        public void Add(string dataIn)
        {
            Array.Resize(ref stack, stackLength + 1);

            int index = stackLength;
            stack[index] = dataIn;
            stackLength++;

            map.Add(dataIn, index);
        }

        public void Remove(string dataIn)
        {
            if (!map.ContainsKey(dataIn)) return;

            int index = map[dataIn];

            map.Remove(dataIn);

            if (dataIn != stack[stackLength - 1])
            {
                map.Remove(stack[stackLength-1]);
                map.Add(stack[stackLength - 1], index);

                var temp = stack[stackLength - 1];
                stack[stackLength - 1] = stack[index];
                stack[index] = temp;
            }

            stackLength--;
        }
    }
}
