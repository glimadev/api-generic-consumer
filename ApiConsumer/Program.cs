using ApiConsumer.Services.Api;
using ApiConsumer.VM;
using ApiConsumer.VM.Out;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
