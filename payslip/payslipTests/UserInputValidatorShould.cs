using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using payslip;
using Xunit;

namespace payslipTests
{
    public class UserInputValidatorShould
    {
        private readonly UserInputValidator _userInputValidator;

        public UserInputValidatorShould()
        {
            _userInputValidator = new UserInputValidator(new UserInputMocks("47657"));
        }
        
        [Theory]
        [InlineData("jkgjkfd",true)]
        [InlineData("asdfghjklasdfghjkcg",false)]
        [InlineData("123456789012345",false)]
        [InlineData("",false)]
        [InlineData("d",true)]
        public void ValidateNames(string name, bool isAllowed) 
        { 
            //must be less than 15 chars and atleast 1
            var result = _userInputValidator.ValidateName(name);
            //Assert.Equal(isAllowed,result);
        }
        
        [Fact]
        public void ValidateNumbers() 
        { 
            //must be an integer
            var result = _userInputValidator.ValidateInteger("47657");
            Assert.Equal(47657,result);
        }
    }
}