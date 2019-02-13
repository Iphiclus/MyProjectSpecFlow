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
       
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator1(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculators")]
        public void GivenIHaveAlsoEnteredIntoTheCalculators(int number)
        {
            calculator.SecondNumber = number;
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

    }
}
