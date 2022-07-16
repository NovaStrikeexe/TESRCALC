using System;
using System.Net.Http;
namespace TestNetCalc.Helpers
{
    public class MathOpertionAPI
    {
        public HttpClient Initial()
        {
            var HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("http://localhost:5010");
            return HttpClient;
        }
    }
}