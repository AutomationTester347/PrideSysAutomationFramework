using NUnit.Framework;
using PrideSysAutomationFramework.Web;

namespace PrideSysAutomationFramework.Tests
{
    [SetUpFixture]
    class TestSetup
    {
        [OneTimeSetUp]
        public void Start()
        {
            TestBase.BeginExecution();
        }

        [OneTimeTearDown]
        public void End()
        {
            TestBase.ExitExecution();
        }
    }
}
