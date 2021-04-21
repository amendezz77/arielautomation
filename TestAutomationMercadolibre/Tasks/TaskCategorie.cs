using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationMercadoLibre.Action;
using TestAutomationMercadoLibre.UI;

namespace TestAutomationMercadoLibre.Tasks
{
    class TaskCategorie
    {
        public static void SelectBenef(IWebDriver driver)
        {
            Moveto.MovetoElemeten(driver,UITest.GetCategorias());
            Moveto.MovetoElemeten(driver, UITest.GetTecnologia());
             Click.On(driver, UITest.GetTelevisores());
            //Click.On(driver, UITest.GetTecnologia());
            //Click.On(driver, UITest.GetPc());
        }


        public static void MenorPrecion(IWebDriver driver)
        {
            Click.On(driver, UITest.GetMasRelevantes());
            
            Click.On(driver, UITest.GetMenorPrecio());


        }

        public static void UltimoItem(IWebDriver driver)
        {
            Click.On(driver, UITest.GetUltimoItem());
        }

        public static void ValidacionPrecio(IWebDriver driver, string a)
        {
            Assert.AssertAreEqual(a, UITest.GetPrecio());
        }
    }
}
