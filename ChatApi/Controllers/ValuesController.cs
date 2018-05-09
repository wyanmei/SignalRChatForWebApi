using ChatApi.Hubs;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatApi.Controllers
{
    public class ValuesController : ApiController
    {
       

        // GET api/values/5
        public string Get(int id)
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
          //  hub.Clients.All.showMessage(id + "");
            return "values";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
        
    }
}
