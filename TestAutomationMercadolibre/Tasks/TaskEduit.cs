using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAutomationMercadoLibre.Action;
using TestAutomationMercadoLibre.UI;

namespace TestAutomationMercadoLibre.Tasks
{
    class TaskEduit
    {
        public static void ClickPestaEmpledo(IWebDriver driver, string a)
        {
            Click.On(driver, UITest.GetEduEmpleos());
            Thread.Sleep(Literales.TimemMed );
            Click.On(driver,UITest.GetSeleccPuesto());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElemeten(driver, UITest.GetPuesto());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UITest.GetPuesto());
            Thread.Sleep(Literales.TimemMed);
            Assert.AssertAreEqual(a, UITest.GetTestingqa());
        }
    }
}
