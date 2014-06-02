using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabbyChatSorter
{
    static class Program
    {
        static void Main()
        {
            string[] strInput = System.IO.File.ReadAllLines(@"C:\Users\Gabe\Desktop\TabbyChatInput.txt");
            Parsing ps = new Parsing();
            Sort st = new Sort();

            strInput = st.comb(ps.parse(strInput), strInput);

            System.IO.File.WriteAllLines(@"C:\Users\Gabe\Desktop\TabbyChatOutput.txt", strInput);
        }
    }
}
