﻿using System.Net.Http;
using Deepgram.Utilities;
using Xunit;

namespace Deepgram.Tests.UtilitiesTests
{
    public class HttpClientUtilTests
    {
        [Fact]
        public void GetUserAgent_Should_Return_HttpClient_With_Accept_And_UserAgent_Headers_Set()
        {
            //Arrange
            var httpClientUtil = new HttpClientUtil();
            var agent = UserAgentUtil.GetUserAgent();

            //Act
            var result = httpClientUtil.HttpClient;

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<HttpClient>(result);
            Assert.Equal("application/json", result.DefaultRequestHeaders.Accept.ToString());
            Assert.Equal(agent, result.DefaultRequestHeaders.UserAgent.ToString());

        }
    }
}