using System;
using TechTalk.SpecFlow;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private int addresult;
        private int subresult;

        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator1(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculators")]
        public void GivenIHaveAlsoEnteredIntoTheCalculators(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            addresult = calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, addresult);
        }

        //Subtract

        [Given(@"I have entered (.*) into the subcalculator")]
        public void GivenIHaveEnteredIntoTheSubcalculator(int subtractnumber)
        {
            calculator.sFirstNumber = subtractnumber;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheSubcalculator(int subtractnumber)
        {
            calculator.sSecondNumber = subtractnumber;
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            subresult = calculator.Subtract();
        }

        [Then(@"the result must be (.*) on the screen")]
        public void ThenTheResultMustBeOnTheScreen(int subexpectedResult)
        {
            Assert.AreEqual(subexpectedResult, subresult);
        }

    }
}
