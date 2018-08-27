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
            var mockInput = new UserInputMocks(new List<string>{"name","name","10000","7","10 m","20 m"});
            var mockOutput = new MockOutputAstext();
            TUI.GetUserInput(mockInput, new MockUserInputValidator(), new MockDisplayMessage(), mockOutput);
            Assert.Equal("testName", mockOutput.WriteText[2]);
            Assert.Equal("testSalary", mockOutput.WriteText[6]);
        }
    }
}