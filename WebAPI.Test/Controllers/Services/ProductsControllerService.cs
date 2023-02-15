using RestSharp;
using System.Configuration;
using WebAPI.Models;

namespace WebAPI.Test.Controllers.Services
{
    public class ProductsControllerService
    {
        private string ControllerName = "Products";
        private string Endpoint;
        public ProductsControllerService()
        {
            Endpoint = ConfigurationManager.AppSettings["endpoint"]!;
        }
        #region base rest call
        public RestResponse GetAll()
        {
            Endpoint = ConfigurationManager.AppSettings["endpoint"]!;
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Get);
            request.AddParameter("pageNumber", "0");
            request.AddParameter("pageSize", "10");
            return client.Get(request);
        }
        public RestResponse GetById(int id)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Get);
            request.AddParameter("id", id);
            return client.Get(request);
        }
        public RestResponse Add(Product product)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Post);
            request.AddBody(product);
            return client.Post(request);
        }
        public RestResponse Update(int id, Product product)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Put);
            request.AddParameter("id", id);
            request.AddBody(product);
            return client.Put(request);
        }
        public RestResponse Delete(int id)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Delete);
            request.AddParameter("id", id);
            return client.Delete(request);
        }
        #endregion
    }
}