using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Service;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XUnitTest
{
    class TestClientProvider
    {
        public HttpClient Client { get; set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
