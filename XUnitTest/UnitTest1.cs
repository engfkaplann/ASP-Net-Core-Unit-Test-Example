using Service.Controllers;
using System;
using System.Net;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async void GetServiceTest()
        {
            var client = new TestClientProvider().Client;

            // Act
            var okResult = await client.GetAsync("values/1");

            okResult.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, okResult.StatusCode);
        }

        [Fact]
        public async void GetServiceTestInvalidValue()
        {
            var client = new TestClientProvider().Client;

            // Act
            var okResult = await client.GetAsync("values/0");

            okResult.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, okResult.StatusCode);
        }
    }
}
