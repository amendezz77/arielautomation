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
    class TestMercadoLibre : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            this.Driver.Url = "https://www.mercadolibre.com.ar/";
        }
        [Test]
        public void TestMercado()
        {
            TaskCategorie.SelectBenef(this.Driver);
            
            TaskCategorie.MenorPrecion(this.Driver);

            TaskCategorie.UltimoItem(this.Driver);

            TaskCategorie.ValidacionPrecio(this.Driver,"22.999");
            //SelectCategorias.SelectBenef(this.Driver);
        }
    }
}
