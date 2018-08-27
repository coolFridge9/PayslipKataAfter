using System.Collections.Generic;
using payslip;
using Xunit;

namespace payslipTests
{
    public class PayslipRendererShould
    {
        [Fact]
        public void renderPayslip()
        {
            var payslipRenderer = new PayslipRenderer();
            var payslip = new MockPaySlip();
            var resultOutput = new MockOutputAstext();
            payslipRenderer.Render(payslip, resultOutput);

            var expected = new List<string>
            {
                "Name: John Doe\n",
                "Pay Period: 01 March – 31 March\n",
                "Gross Income: 5004\n",
                "Income Tax: 922\n",
                "Net Income:4082\n",
                "Super: 450\n"
            };

            Assert.Equal(expected,resultOutput.WriteText);
        }

    }

    public class PayslipRenderer
    {
        public void Render(PaySlipInterface payslip, OutInterface output)
        {
            output.Print("Name :"+payslip.Name()+"\n");
            output.Print("Pay Period: "+payslip.PayPeriod()+"\n");
            output.Print("Gross Income: "+payslip.GrossIncome()+"\n");
            output.Print("Income Tax: "+ payslip.Tax()+"\n");
            output.Print("Net Income: "+payslip.NetIncome()+"\n");
            output.Print("Super: "+payslip.Super()+"\n");
        }
    }
}