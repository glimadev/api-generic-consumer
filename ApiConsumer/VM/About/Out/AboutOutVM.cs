using ApiConsumer.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsumer.VM.Out
{
    public class AboutOutVM : ResultService
    {
        public AboutOutVM()
        {
            this.About = new AboutVM();
        }

        public AboutVM About { get; set; }
    }
}
