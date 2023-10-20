using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            (new SmartArgsPackage.Tester.SmartArgsTester() { WaitForKeyPressOnCompletion = true }).Run(args);
        }
    }
}
