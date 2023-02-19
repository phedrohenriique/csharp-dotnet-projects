using System;

namespace Script
{

    class Script
    {
        static void Main()
        {
            Console.WriteLine("Script Running");
            AnotherScript script = new AnotherScript();
            script.AnotherFunction();
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"The number is {i}");
            }
        }
    }

    class AnotherScript
    {
        public void AnotherFunction()
        {
            Console.WriteLine("Another Class Object");
        }
    }
}