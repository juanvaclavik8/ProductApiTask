using Moq;
using ProductApiTask.Controllers;
using ProductApiTask.DataAccessLayer;
using ProductApiTask.ServiceLayer;

namespace ProductApiTask.Tests
{
    public class UnitTests
    {
        [Fact]
        public void GetProduct_ReturnsOK_WhenID1()
        {
            // Arrange
            var mockLogging = new Mock<Logging.Logging>();
            var mockDataAccess = new Mock<DataAccess>();
            var mockService = new Mock<ProductService>(mockDataAccess.Object, mockLogging.Object);
            var controller = new ProductController(mockService.Object);

            // Act
            var result = controller.GetProduct(1);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void GetProduct_ReturnsOK_WhenID2()
        {
            // Arrange
            var mockLogging = new Mock<Logging.Logging>();
            var mockDataAccess = new Mock<DataAccess>();
            var mockService = new Mock<ProductService>(mockDataAccess.Object, mockLogging.Object);
            var controller = new ProductController(mockService.Object);

            // Act
            var result = controller.GetProduct(2);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void GetProduct_ReturnsOK_WhenID3()
        {
            // Arrange
            var mockLogging = new Mock<Logging.Logging>();
            var mockDataAccess = new Mock<DataAccess>();
            var mockService = new Mock<ProductService>(mockDataAccess.Object, mockLogging.Object);
            var controller = new ProductController(mockService.Object);

            // Act
            var result = controller.GetProduct(3);

            // Assert
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void GetProduct_ReturnsNotOK_WhenID50()
        {
            // Arrange
            var mockLogging = new Mock<Logging.Logging>();
            var mockDataAccess = new Mock<DataAccess>();
            var mockService = new Mock<ProductService>(mockDataAccess.Object, mockLogging.Object);
            var controller = new ProductController(mockService.Object);

            // Act
            var result = controller.GetProduct(50);

            // Assert
            Assert.True(!result.IsSuccess);
        }

        [Fact]
        public void GetProduct_ReturnsNotOK_WhenID100()
        {
            // Arrange
            var mockLogging = new Mock<Logging.Logging>();
            var mockDataAccess = new Mock<DataAccess>();
            var mockService = new Mock<ProductService>(mockDataAccess.Object, mockLogging.Object);
            var controller = new ProductController(mockService.Object);

            // Act
            var result = controller.GetProduct(100);

            // Assert
            Assert.True(!result.IsSuccess);
        }
    }
}