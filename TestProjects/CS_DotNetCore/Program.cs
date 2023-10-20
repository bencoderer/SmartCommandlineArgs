using System;
using System.Linq;

namespace CS_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            (new SmartArgsPackage.Tester.SmartArgsTester() { WaitForKeyPressOnCompletion = false }).Run(args);
        }
    }
}
