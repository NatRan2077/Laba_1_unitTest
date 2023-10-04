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
            s1.InstallApp("App1", 10); // ������������� ���������� � ��������� "App1"

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                s1.InstallApp("App1", 20); // �������� ���������� ���������� � ��� ������������ ���������

                // Assert
                string expectedErrorMessage = "���������� � ����� ��������� ��� ����������. ��������� ��������.";
                string actualOutput = sw.ToString().Trim();
                Assert.AreEqual(expectedErrorMessage, actualOutput);
            }
        }

        //[TestMethod]
        //public void TestInstallApp()
        //{
        //    // ������� ������ ������, ����������� ������� InstallApp
        //    Smartphone yourClass = new Smartphone("Apple", "SE", 1.7, 8, 6, "LPDDR3", 128, "IOS", "346741084731834");

        //    // ������ ��������� ���������
        //    yourClass.apps = new List<App>
        //    {
        //     new App("App1", 10),
        //     new App("App2", 20),                                                                 ////������� �� �������� 
        //     new App("App3", 20)
        //    };

        //    yourClass.memory_used = 0;
        //    //yourClass.memory = 100;


        //    // �������� ����������� �������
        //    yourClass.InstallApp("App4", 15);

            
        //    // ��������� ��������� ������� ����� ������ �������
        //    Assert.AreEqual(4, yourClass.apps.Count);
        //    Assert.AreEqual(50, yourClass.memory_used); ///
        //}



        [TestMethod]
        public void TestDeleteApp()
        {
            // ������� ������ ������, ����������� ������� DeleteApp
            Smartphone s1 = new Smartphone("Apple", "SE", 1.7, 8, 6, "LPDDR3", 128, "IOS", "346741084731834");

            // ������ ��������� ���������
            s1.apps = new List<App>
                {
                    new App("App1", 10.0),
                    new App("App2", 20.0)
                };

            // �������������� ���������
            string expectedOutput1 = "���������� � ��������� App1 �������.";
            string expectedOutput2 = "���������� � ��������� App3 �� ����������. �������� �� ���������.";

            // �������� ����������� �������
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

            // ��������� ��������� ������� ����� ������ �������
            Assert.AreEqual(1, s1.apps.Count);
            Assert.AreEqual("App2", s1.apps[0].name);
        }
    }
}
