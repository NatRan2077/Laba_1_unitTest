global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba1;
namespace Testlaba1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstallApp_ExistingAppName_ReturnsErrorMessage()
        {
            // Arrange
            Smartphone s1 = new Smartphone("Apple", "SE", 1.7, 8, 6, "LPDDR3", 128, "IOS", "346741084731834");
            s1.InstallApp("App1", 10); // Устанавливаем приложение с названием "App1"

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                s1.InstallApp("App1", 20); // Пытаемся установить приложение с уже существующим названием

                // Assert
                string expectedErrorMessage = "Приложение с таким названием уже существует. Установка отменена.";
                string actualOutput = sw.ToString().Trim();
                Assert.AreEqual(expectedErrorMessage, actualOutput);
            }
        }

        //[TestMethod]
        //public void TestInstallApp()
        //{
        //    // Создаем объект класса, содержащего функцию InstallApp
        //    Smartphone yourClass = new Smartphone("Apple", "SE", 1.7, 8, 6, "LPDDR3", 128, "IOS", "346741084731834");

        //    // Задаем начальное состояние
        //    yourClass.apps = new List<App>
        //    {
        //     new App("App1", 10),
        //     new App("App2", 20),                                                                 ////Чертила не работает 
        //     new App("App3", 20)
        //    };

        //    yourClass.memory_used = 0;
        //    //yourClass.memory = 100;


        //    // Вызываем тестируемую функцию
        //    yourClass.InstallApp("App4", 15);

            
        //    // Проверяем состояние объекта после вызова функции
        //    Assert.AreEqual(4, yourClass.apps.Count);
        //    Assert.AreEqual(50, yourClass.memory_used); ///
        //}



        [TestMethod]
        public void TestDeleteApp()
        {
            // Создаем объект класса, содержащего функцию DeleteApp
            Smartphone s1 = new Smartphone("Apple", "SE", 1.7, 8, 6, "LPDDR3", 128, "IOS", "346741084731834");

            // Задаем начальное состояние
            s1.apps = new List<App>
                {
                    new App("App1", 10.0),
                    new App("App2", 20.0)
                };

            // Предполагаемый результат
            string expectedOutput1 = "Приложение с названием App1 удалено.";
            string expectedOutput2 = "Приложение с названием App3 не существует. Удаление не произошло.";

            // Вызываем тестируемую функцию
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                s1.DeleteApp("App1");
                string actualOutput1 = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput1, actualOutput1);
            }

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                s1.DeleteApp("App3");
                string actualOutput2 = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput2, actualOutput2);
            }

            // Проверяем состояние объекта после вызова функции
            Assert.AreEqual(1, s1.apps.Count);
            Assert.AreEqual("App2", s1.apps[0].name);
        }
    }
}
