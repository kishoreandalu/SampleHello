using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CroweConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:6456/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Hello").Result;
            if (response.IsSuccessStatusCode)
            {
                var message = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(message);
                Console.ReadLine();
            }
            else
            {
                Console.Write("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
