using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using payslip;
using Xunit;

namespace payslipTests
{
    public class UserInputValidatorShould
    {

        [Fact]
        public void ValidateNames() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>()));
            var result = inputValidator.ValidateName("maaa");
            Assert.Equal("maaa",result);
        }
        
        [Fact]
        public void ValidateNamesUntilValid() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>{"tim"}));
            var result = inputValidator.ValidateName("");
            Assert.Equal("tim",result);
        }
        
        [Fact]
        public void ValidateNumbers() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>()));
            var result = inputValidator.ValidateInteger("47657");
            Assert.Equal(47657,result);
        }
        
        [Fact]
        public void AcceptNumbersUntilValid() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>{"3333"}));
            var result = inputValidator.ValidateInteger("sdfbf");
            Assert.Equal(3333,result);
        }
        
        [Fact]
        public void AcceptNumbersUntilValid2() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>{"xkfjnlfn","dgf","565"}));
            var result = inputValidator.ValidateInteger("sdfbf");
            Assert.Equal(565,result);
        }
        
        [Fact]
        public void ValidateDates() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>()));
            var result = inputValidator.ValidateDate("31 March");
            Assert.Equal("31 March",result);
        }
        
        [Fact]
        public void ValidateDatesUntilValid() 
        { 
            var inputValidator = new UserInputValidator(new UserInputMocks(new List<string>{"dsf","10 may"}));
            var result = inputValidator.ValidateDate("xdksnf");
            Assert.Equal("10 may",result);
        }
    }
}