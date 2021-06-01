using System;

namespace Chapter._6_CommandPattern
{
    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("No Command");
        }
    }


}
