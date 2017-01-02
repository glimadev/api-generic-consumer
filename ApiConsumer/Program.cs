using ApiConsumer.Services.Api;
using ApiConsumer.VM.Out;

namespace ApiConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get
            AboutOutVM aboutOutVM = new ApiService<AboutOutVM>().Get("About", "Get","pt-br").Result;
        }
    }
}
