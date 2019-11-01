using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaksoipistedee
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            string outputString = ":";

            Random random = new Random();
            int outputLength = random.Next(10, 30);

            for(int i = 0; i < outputLength; i++)
            {
                int nextCharacter = random.Next(1, 3);

                if(nextCharacter == 1)
                {
                    outputString += ':';
                }
                else
                {
                    outputString += 'D';
                }
            }

            outputString += 'D';

            Clipboard.SetText(outputString);
        }
    }
}
