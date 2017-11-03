using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Program Name: {0}", ProgramName));
            Console.WriteLine(string.Format("Program Version: {0}{1}", ProgramVersion, Environment.NewLine));

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            Console.Write("Press any key to exit.");
            Console.Read();
        }

        static string ProgramName
        {
            get
            {
                string[] segments = Assembly
                    .GetEntryAssembly()
                    .GetName()
                    .ToString()
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                return segments[0];
            }
        }

        static string ProgramVersion
        {
            get
            {
                return Assembly
                    .GetEntryAssembly()
                    .GetName()
                    .Version
                    .ToString();
            }
        }
    }
}
