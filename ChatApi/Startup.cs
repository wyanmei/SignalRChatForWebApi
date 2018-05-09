using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(ChatApi.Startup))]

namespace ChatApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 连接标识
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll); //跨域
                map.RunSignalR(new HubConfiguration { EnableJSONP = true });
            });
        }
    }
}
