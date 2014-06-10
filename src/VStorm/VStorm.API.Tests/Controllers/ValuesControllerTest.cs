using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using VStorm.API.Controllers;

namespace VStorm.API.Tests.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            var controller = new ValuesController();

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
            var controller = new ValuesController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [Test]
        public void Post()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [Test]
        public void Put()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Test]
        public void Delete()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
