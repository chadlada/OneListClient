using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OneListClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var responseBodyAsString = await client.GetStringAsync("https://one-list-api.herokuapp.com/items/1?access_token=sdg-handbook");
            Console.WriteLine(responseBodyAsString);
        }
    }
}
