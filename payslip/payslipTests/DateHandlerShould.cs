using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using payslip;
using Xunit;

namespace payslipTests
{
    public class DateHandlerShould
    {
        [Fact]
        public void ReturnDateTimeFormat()
        {
            var start = "1 March";
            var end = "31 March";
            var dateHandler = new DateHandler(start,end);
            var result = dateHandler.ToString();
            var expected = "01 March - 31 March";
            Assert.Equal(expected,result);

        }

        [Fact]
        public void ReturnNumOfDays() //see if this needs doing or if its always 1 month
        {
            
        }
      
    }
}