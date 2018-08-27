//using payslip;
//using Xunit;
//
//namespace payslipTests
//{
//    public class TUIShould
//    {
//        [Fact]
//        public void DisplayTUI()
//        {
//            var TUI = new TUI();
//            var inputReader = new UserInputMocks();
//            var result = TUI.GetUserInput(inputReader);
//        }
//    }
//
//    public class TUI
//    {
//        public PaySlip GetUserInput(InputReaderInterface inputReader)
//        {
//            var firstName = inputReader.ReadFirstName();
//            var surname = inputReader.ReadSurname();
//            var salary = inputReader.ReadSalary();
//            var super = inputReader.ReadSuper();
//            var startDate = inputReader.ReadStartDate();
//            var endDate = inputReader.ReadEndDate();
//            
//            return new PaySlip(firstName,surname,);
//        }
//    }
//}