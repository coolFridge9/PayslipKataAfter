using System.Collections.Generic;
using payslip;
using Xunit;

namespace payslipTests
{
    public class TUIShould
    {
        [Fact]
        public void DisplayTUI()
        {
            var TUI = new TUI();
            var inputReader = new UserInputMocks(new List<string>());
            var result = TUI.GetUserInput(inputReader, new MockUserInputValidator());
        }
    }

    public class TUI
    {
        public PaySlip GetUserInput(InputReaderInterface inputReader, InputValidatorInterface validator)
        {
            var firstName = validator.ValidateName(inputReader.Read());
            var surname = validator.ValidateName(inputReader.Read());
            var salary = validator.ValidateInteger(inputReader.Read());
            var super = validator.ValidateInteger(inputReader.Read());
            var startDate = inputReader.Read();
            var endDate = inputReader.Read();
            
            return new PaySlip(firstName,surname,salary,super,startDate,endDate);
        }
    }
}