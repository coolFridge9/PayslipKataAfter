using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TUI();
            t.GetUserInput(new ConsoleReader(), new UserInputValidator(new ConsoleReader()),new DisplayMessages(), new ConsoleWriter() );
        }
    }
}