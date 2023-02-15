using WebAPI.Models;
using WebAPIClient.Controllers.Services;

namespace WebAPIClient.Controllers.Tests
{
    public class ProductsControllerTests
    {
        private ProductsControllerService _service;
        public ProductsControllerTests()
        {
            _service = new ProductsControllerService();
        }
        public void GetAll()
        {
            var response = _service.GetAll();
            Console.WriteLine(response.Content);
        }
        public void GetById()
        {
            var response = _service.GetById(1);
            Console.WriteLine(response.Content);
        }
        public void Add()
        {
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
            var response = _service.Add(product);
            Console.WriteLine(response.Content);
        }
        public void Update()
        {
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
            var response = _service.Update(78, product);
            Console.WriteLine(response.Content);
        }
        public void Delete()
        {
            var response = _service.Delete(78);
            Console.WriteLine(response.Content);
        }
    }
}