using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrjWebUnitTestProject
{
    [TestClass]
    public class TesteEst
    {
        [TestMethod]
        public void valida_Verificar1hora()
        {
            // Arrange
            string inputTimeStr = "17:00";
            string outputTimeStr = "18:00";
            DateTime inputTime = DateTime.ParseExact(inputTimeStr, "HH:mm", null);
            DateTime outputTime = DateTime.ParseExact(outputTimeStr, "HH:mm", null);

            // Act
            TimeSpan timeDifference = outputTime - inputTime;

            // Assert
            TimeSpan expectedTimeDifference = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(0));
            Assert.AreEqual(expectedTimeDifference, timeDifference, "Ok.");
        }

        [TestMethod]
        public void valida_Verificar2horas()
        {
            // Arrange
            string inputTimeStr = "17:00";
            string outputTimeStr = "19:00";
            DateTime inputTime = DateTime.ParseExact(inputTimeStr, "HH:mm", null);
            DateTime outputTime = DateTime.ParseExact(outputTimeStr, "HH:mm", null);

            // Act
            TimeSpan timeDifference = outputTime - inputTime;

            // Assert
            TimeSpan expectedTimeDifference = TimeSpan.FromHours(3).Add(TimeSpan.FromMinutes(0));
            Assert.AreEqual(expectedTimeDifference, timeDifference, "dar erro porque era para dar 2 horas e não 3.");
        }
        public void valida_Verificar2horasOk()
        {
            // Arrange
            string inputTimeStr = "17:00";
            string outputTimeStr = "19:00";
            DateTime inputTime = DateTime.ParseExact(inputTimeStr, "HH:mm", null);
            DateTime outputTime = DateTime.ParseExact(outputTimeStr, "HH:mm", null);

            // Act
            TimeSpan timeDifference = outputTime - inputTime;

            // Assert
            TimeSpan expectedTimeDifference = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(0));
            Assert.AreEqual(expectedTimeDifference, timeDifference, "Ok");
        }
        [TestMethod]
        public void valida_Verificar3horas()
        {
            // Arrange
            string inputTimeStr = "17:00";
            string outputTimeStr = "20:00";
            DateTime inputTime = DateTime.ParseExact(inputTimeStr, "HH:mm", null);
            DateTime outputTime = DateTime.ParseExact(outputTimeStr, "HH:mm", null);

            // Act
            TimeSpan timeDifference = outputTime - inputTime;

            // Assert
            TimeSpan expectedTimeDifference = TimeSpan.FromHours(3).Add(TimeSpan.FromMinutes(0));
            Assert.AreEqual(expectedTimeDifference, timeDifference, "Ok.");
        }
        [TestMethod]
        public void valida_Verificar4horas()
        {
            // Arrange
            string inputTimeStr = "17:00";
            string outputTimeStr = "21:00";
            DateTime inputTime = DateTime.ParseExact(inputTimeStr, "HH:mm", null);
            DateTime outputTime = DateTime.ParseExact(outputTimeStr, "HH:mm", null);

            // Act
            TimeSpan timeDifference = outputTime - inputTime;

            // Assert
            TimeSpan expectedTimeDifference = TimeSpan.FromHours(4).Add(TimeSpan.FromMinutes(0));
            Assert.AreEqual(expectedTimeDifference, timeDifference, "Ok.");
        }
        [TestMethod]
        public void valida_Verificar5horas()
        {
            // Arrange
            string inputTimeStr = "17:00";
            string outputTimeStr = "22:00";
            DateTime inputTime = DateTime.ParseExact(inputTimeStr, "HH:mm", null);
            DateTime outputTime = DateTime.ParseExact(outputTimeStr, "HH:mm", null);

            // Act
            TimeSpan timeDifference = outputTime - inputTime;

            // Assert
            TimeSpan expectedTimeDifference = TimeSpan.FromHours(5).Add(TimeSpan.FromMinutes(0));
            Assert.AreEqual(expectedTimeDifference, timeDifference, "Ok.");
        }
     
    }
}
