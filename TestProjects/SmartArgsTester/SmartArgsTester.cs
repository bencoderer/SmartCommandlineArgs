using System;
using System.Linq;

namespace SmartArgsPackage.Tester
{
    public class SmartArgsTester
    {
        public bool WaitForKeyPressOnCompletion { get; set; } = false;

        public void Run(string[] args)
        {
            // Display command line arguments
            Console.WriteLine("Command Line Arguments:");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            // Display environment variables
            Console.WriteLine("\nEnvironment Variables:");
            foreach (var key in Environment.GetEnvironmentVariables().Keys.OfType<string>().Where(x => x.StartsWith("SCA_", StringComparison.InvariantCultureIgnoreCase)))
            {
                Console.WriteLine($"{key} = {Environment.GetEnvironmentVariable(key.ToString())}");
            }

            // Display working dir
            Console.WriteLine("\nWorking directory:");
            Console.WriteLine(Environment.CurrentDirectory);

            if (WaitForKeyPressOnCompletion)
            {
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
            }
        }
    }
}