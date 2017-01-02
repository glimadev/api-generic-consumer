using System.Collections.Generic;

namespace ApiConsumer.Services.Api
{
    public class ResultService : IResultService
    {
        public ResultService()
        {
            this.Messages = new List<string>();
            this.SuccessMessage = null;
        }

        public bool Success
        {
            get
            {
                return this.Messages.Count == 0;
            }
        }

        public List<string> Messages { get; set; }

        public string SuccessMessage { get; set; }
    }
}
