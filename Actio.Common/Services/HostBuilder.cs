using System;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Actio.Common.Services
{
    public class HostBuilder : BuildBase
    {
        private readonly IWebHost webHost;

        private IBusClient bus;

        public HostBuilder(IWebHost webHost) => this.webHost = webHost;

        public BusBuilder UseRabbitMq()
        {
            bus = (IBusClient)webHost.Services.GetService(typeof(IBusClient));

            return new BusBuilder(webHost, bus);
        }

        public override ServiceHost Build() => new ServiceHost(webHost);
    }
}