using System;

namespace payslip
{
    public class ConsoleReader : InputReaderInterface
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}