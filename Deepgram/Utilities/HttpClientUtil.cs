﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Deepgram.Utilities
{
    public class HttpClientUtil
    {
        // Client used in instance when needed
        internal HttpClient HttpClient { get; private set; }

        internal HttpClientUtil() {
            HttpClient = Create();
        }

        /// <summary>
        /// Create a Httpclient set common headers
        /// </summary>
        /// <returns></returns>
        private HttpClient Create()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgentUtil.GetUserAgent());

            return httpClient;
        }

        /// <summary>
        /// sets timeout on the httpclient
        /// </summary>
        /// <param name="timeSpan"></param>
        public void SetTimeOut(TimeSpan timeSpan)
        {
            // If the timeout has a new value, create a new HttpClient
            if (HttpClient.Timeout != timeSpan)
            {
                // HttpClient = Create(); // temporary bug fix until SDK v4 is released
            }

            // Set the timeout
            HttpClient.Timeout = timeSpan;
        }
    }
}
