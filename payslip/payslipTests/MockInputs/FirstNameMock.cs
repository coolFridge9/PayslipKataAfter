using System.Reflection.Metadata.Ecma335;
using payslip;

namespace payslipTests
{
    public class FirstNameMock : InputReaderInterface
    {
        public string ReadInput()
        {
            return "John";
        }
    }
}