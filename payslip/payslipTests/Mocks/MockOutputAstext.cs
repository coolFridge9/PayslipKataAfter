using System.Collections.Generic;
using payslip;

namespace payslipTests
{
    public class MockOutputAstext : OutInterface
    {
        public readonly List<string> WriteText = new List<string>();
        public void Print(string text)
        {
            WriteText.Add(text);
        }
    }
}