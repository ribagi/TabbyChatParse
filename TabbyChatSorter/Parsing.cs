using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbyChatSorter
{
    class Parsing
    {
        public int[] parse(string[] strInput)
        {
            int[] input = new int[strInput.Length];

            for(int i = 0; i < strInput.Length; i++){
                string[] list = strInput[i].Split(' ', ':');
                try{                    
                    input[i] = Int32.Parse(list[2]);
                }
                catch (FormatException e){
                    Console.WriteLine(e.Message);
                }
            }

            return input;
        }
    }
}
