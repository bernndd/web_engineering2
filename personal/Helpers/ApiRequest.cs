using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace personal.Helpers
{
    public class ApiRequest
    {
        public ApiRequest()
        {
           
        }
        public static async Task<bool> HTTPreq(string url)
        {
            //string AssetsUri = Environment.GetEnvironmentVariable("ASSETS_ROOM_URI") ?? "http://localhost/api/assets/rooms/";

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
            using HttpResponseMessage response = await httpClient.GetAsync(url);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

    }

}
