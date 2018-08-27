using payslip;

namespace payslipTests
{
    public class MockDisplayMessage : DisplayMessageInterface
    {
        public string Welcome()
        {
            return "testWelcome";
        }

        public string GetName()
        {
            return "testName";
        }

        public string GetSurname()
        {
            return "testSurname";
        }

        public string GetSalary()
        {
            return "testSalary";
        }

        public string GetSuperRate()
        {
            return "testSuperRate";
        }

        public string GetPaymentStartDate()
        {
            return "testStart";
        }

        public string GetPaymentEndDate()
        {
            return "testEnd";
        }

        public string NewLine()
        {
            return "TestNewLine";
        }

        public string ThankUser()
        {
            return "testThank";
        }

        public string Error()
        {
            return "test";
        }
    }
}