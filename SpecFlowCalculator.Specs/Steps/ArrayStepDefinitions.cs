using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public class ArraySteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DataStructures.Array _array = new DataStructures.Array();
        private int[] _result;

        public ArraySteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"an array (.*) of size (.*)")]
        public void GivenAnArrayOfSize(string p0, int p1)
        {
            //ScenarioContext.Current.Pending();
            string[] ch = p0.Split(", ");
            int[] a = new int[ch.Length];
            for(int i=0;i<ch.Length;i++)
            {
                a[i] = Convert.ToInt32(ch[i]);
            }
            _array.arr = a;
            _array.n = p1;
        }
        
        [When(@"the array is rotated by (.*) elements")]
        public void WhenTheArrayIsRotatedByElements(int p0)
        {
            //ScenarioContext.Current.Pending();
            _result = _array.rotateArray(p0);
        }
        
        [Then(@"the array (.*) should be returned")]
        public void ThenTheArrayShouldBeReturned(string result)
        {
            //ScenarioContext.Current.Pending();
            string[] ch = result.Split(", ");
            int[] a = new int[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                a[i] = Convert.ToInt32(ch[i]);
            }

            Assert.Equal(_result,a);
        }
    }
}
