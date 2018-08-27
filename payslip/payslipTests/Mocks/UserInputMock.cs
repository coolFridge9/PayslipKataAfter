using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using payslip;

namespace payslipTests
{
    public class UserInputMocks : InputReaderInterface
    {
        private readonly List<string> _custom;
        private int index = 0;
        public UserInputMocks(List<string> custom)
        {
            _custom = custom;
        }
        public string ReadFirstName()
        {
            return "John";
        }

        public string ReadSurname()
        {
            return "Doe";
        }

        public string ReadSalary()
        {
            return "60050";
        }

        public string ReadSuper()
        {
            return "9";
        }

        public string ReadStartDate()
        {
            return "1 March";
        }

        public string ReadEndDate()
        {
            return "31 March";
        }

        public string Read()
        {
            return _custom;
        }
    }
}