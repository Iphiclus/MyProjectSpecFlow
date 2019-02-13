using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Specs
{
    [Binding]
    public class SubtractCalculatorSteps
    {
        private int subresult;

        private CalculatorSubtract subcalculator = new CalculatorSubtract();

        [Given(@"I have entered (.*) into the subcalculator")]
        public void GivenIHaveEnteredIntoTheSubcalculator(int subnumbber)
        {
            subcalculator.SFirstNumber = subnumbber;
        }

        [Given(@"I have entered (.*) into the subcalculators")]
        public void GivenIHaveEnteredIntoTheSubcalculators(int subnumbber)
        {
            subcalculator.SSecondNumber = subnumbber;
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            subresult = subcalculator.Subtract();
        }

        [Then(@"the result must be (.*) on the screen")]
        public void ThenTheResultMustBeOnTheScreen(int SubexpectedResult)
        {
            Assert.AreEqual(SubexpectedResult, subresult);
        }


    }
}
