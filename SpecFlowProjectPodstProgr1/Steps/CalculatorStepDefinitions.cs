using TechTalk.SpecFlow;
using MyUtilities;

namespace SpecFlowProjectPodstProgr1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private float _result;
     


        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"the teperature in F")]
        public void GivenTheTeperatureInF(float f)
        {
            tempF = f;
        }

        [When(@"is converted")]
        public void WhenIsConverted()
        {
            _result = WeatherUtilities.FnaC(tempF);
        }

        [Then(@"the result temperature should be (.*)")]
        public void ThenTheResultTemperatureShouldBe(float _result)
        {
            _result.Should().Be(float.Parse(_result));
        }
    }
}



