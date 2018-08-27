using payslip;

namespace payslipTests
{
    public class MockUserInputValidator : InputValidatorInterface
    {
        public string ValidateName(string name)
        {
            return name;
        }

        public int ValidateInteger(string num)
        {
            return 5;
        }
    }
}