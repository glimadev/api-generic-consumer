using System;
using System.Collections.Generic;

namespace ApiConsumer.Services.Api
{
    public interface IResultService
    {
        bool Success { get; }

        List<string> Messages { get; set; }

        string SuccessMessage { get; set; }
    }
}
