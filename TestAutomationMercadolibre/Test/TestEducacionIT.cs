using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationMercadoLibre.Tasks;
using TestAutomationMercadoLibre.UI;

namespace TestAutomationMercadoLibre.Test
{
    [TestFixture]
    class TestEducacionIT : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            this.Driver.Url = "https://www.educacionit.com/index";
        }

        [Test]
        public void TestEmpleos()
        {
            TaskEduit.ClickPestaEmpledo(this.Driver, "Testing QA");
        }

    }
}
 