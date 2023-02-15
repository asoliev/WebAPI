using System.Net;
using WebAPI.Models;
using WebAPI.Test.Controllers.Services;

namespace WebAPI.Test.Controllers.Tests
{
    public class ProductsControllerTests
    {
        [Test]
        public void GetAllTest()
        {
            //Arrange
            var p = new ProductsControllerService();

            //Act
            var response = p.GetAll();

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void GetByIdTest()
        {
            //Arrange
            var p = new ProductsControllerService();

            //Act
            var response = p.GetById(1);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void AddTest()
        {
            //Arrange
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
            var p = new ProductsControllerService();

            //Act
            var response = p.Add(product);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void UpdateTest()
        {
            //Arrange
            var product = new Product();
            var p = new ProductsControllerService();

            //Act
            var response = p.Update(product.ProductId, product);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }

        [Test]
        public void DeleteTest()
        {
            //Arrange
            var p = new ProductsControllerService();

            //Act
            var response = p.Delete(1);

            //Assert
            Assert.IsNull(response.ErrorException, "response.ErrorException: {0}", response.ErrorException?.Message);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status is not success");
            Assert.IsNotNull(response.Content);
        }
    }
}