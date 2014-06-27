using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using VStorm.Controllers;
using VStorm.Models;

namespace VStorm.Tests.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            var mock = new Mock<IValuesProvider>();

            mock.Setup(x => x.GetValues()).Returns(new string[] { "value1", "value2" });
            var controller = new ValuesController(mock.Object);

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [Test]
        public void GetById()
        {
            // Arrange
            var mock = new Mock<IValuesProvider>();
            var controller = new ValuesController(mock.Object);

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [Test]
        public void Post()
        {
            // Arrange
            var mock = new Mock<IValuesProvider>();
            var controller = new ValuesController(mock.Object);

            // Act
            controller.Post("value");

            // Assert
        }

        [Test]
        public void Put()
        {
            // Arrange
            var mock = new Mock<IValuesProvider>();
            var controller = new ValuesController(mock.Object);

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Test]
        public void Delete()
        {
            // Arrange
            var mock = new Mock<IValuesProvider>();
            var controller = new ValuesController(mock.Object);

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
