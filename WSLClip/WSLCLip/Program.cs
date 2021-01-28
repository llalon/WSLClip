using System;
using System.Windows.Forms;

namespace WSLCLip
{
    static class Program
    {
        [STAThread]
        static int Main(string[] args)
        {

            string szClip = System.String.Empty;

            // Test if input arguments were supplied.
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No argument given");
                return 1;
            }

            else
            {
                szClip = args[0];
                Clipboard.SetText(szClip);
            }

            return 0;
        }
    }
}
