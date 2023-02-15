using System.Net;
using WebAPI.Models;
using WebAPI.Test.Controllers.Services;

namespace WebAPI.Test.Controllers.Tests
{
    public class CategoriesControllerTests
    {
        [Test]
        public void GetAllTest()
        {
            //Act & Arrange
            var response = CategoriesControllerService.GetAll();

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void GetByIdTest()
        {
            //Act & Arrange
            var response = CategoriesControllerService.GetById(1);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void AddTest()
        {
            //Act
            var product = new Product
            {
                ProductId = 78,
                ProductName = "Test",
                SupplierId = 1,
                CategoryId = 1,
                QuantityPerUnit = "100 ml",
                UnitPrice = 11,
                UnitsInStock = 10,
                UnitsOnOrder = 10,
                ReorderLevel = 10,
                Discontinued = false
            };

            //Arrange
            var response = CategoriesControllerService.Add(product);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void UpdateTest()
        {
            //Act
            var product = new Product();

            //Arrange
            var response = CategoriesControllerService.Update(product.ProductId, product);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void DeleteTest()
        {
            //Act & Arrange
            var response = CategoriesControllerService.Delete(1);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }
    }
}