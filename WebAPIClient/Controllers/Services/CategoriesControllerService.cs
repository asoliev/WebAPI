using RestSharp;
using System.Configuration;
using WebAPI.Models;

namespace WebAPIClient.Controllers.Services
{
    public static class CategoriesControllerService
    {
        private static string ControllerName = "Categories";
        private static string Endpoint;
        static CategoriesControllerService()
        {
            Endpoint = ConfigurationManager.AppSettings["endpoint"]!;
        }
        #region base rest call
        public static RestResponse GetAll()
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Get);
            request.AddParameter("pageNumber", "0");
            request.AddParameter("pageSize", "10");
            return client.Get(request);
        }
        public static RestResponse GetById(int id)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Get);
            request.AddParameter("id", id);
            return client.Get(request);
        }
        public static RestResponse Add(Product product)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Post);
            request.AddBody(product);
            return client.Post(request);
        }
        public static RestResponse Update(int id, Product product)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Put);
            request.AddParameter("id", id);
            request.AddBody(product);
            return client.Put(request);
        }
        public static RestResponse Delete(int id)
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(ControllerName, Method.Delete);
            request.AddParameter("id", id);
            return client.Delete(request);
        }
        #endregion
    }
}