using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbyChatSorter
{
    class Sort
    {
        public string[] comb(int[] input, string[] strInput)
        {
            string swaping;
            const float shrink = 1.3f;
            int swap, i, gap = input.Length;
            bool swapped = false;

            while ((gap > 1) || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)((float)gap / shrink);
                }

                swapped = false;

                for (i = 0; gap + i < input.Length; i++)
                {
                    if (input[i] > input[i + gap])
                    {
                        swap = input[i];
                        swaping = strInput[i];

                        input[i] = input[i + gap];
                        strInput[i] = strInput[i + gap];

                        input[i + gap] = swap;
                        strInput[i + gap] = swaping;

                        swapped = true;
                    }
                }

            }

            return strInput;
        }
    }
}
