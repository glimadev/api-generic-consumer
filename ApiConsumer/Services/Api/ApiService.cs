using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiConsumer.Services.Api
{
    public class ApiService<T> : IApiService<T> where T : class, IResultService
    {
        public const string endPoint = "http://alugaria.com.br/api";

        public async Task<T> Get(string controller, string action, string data)
        {
            T responseService = null;

            using (HttpClient httpClient = new HttpClient())
            {
                string URL = string.Format("{0}/{1}/{2}/{3}", endPoint, controller, action, data);
                
                try
                {
                    var response = await httpClient.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        string strResponse = await response.Content.ReadAsStringAsync();

                        responseService = JsonConvert.DeserializeObject<T>(strResponse);

                        if (responseService.Success)
                        {
                            //TODO:
                        }
                    }
                }
                catch (Exception ex)
                {
                    //TODO:
                }
            }

            return responseService;
        }

        public Task<T> Post(string controller, string action, string data)
        {
            throw new NotImplementedException();
        }
    }
}
