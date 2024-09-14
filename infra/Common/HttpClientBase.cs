using System;
using System.Text;

namespace infra.Common
{
    public class HttpClientBase
    {
        private static readonly HttpClient client = new HttpClient();



        public HttpClientBase()
        {
        }


        protected Task<HttpResponseMessage> Post(string uri, Dictionary<string, string> body)
        {
            HttpContent? content = new FormUrlEncodedContent(body);
            return client.PostAsync(uri, content ?? null);
        }

        protected Task<HttpResponseMessage> Post(string uri,string json)
        {
            HttpContent? content = new StringContent(json, Encoding.UTF8, "application/json");
            return client.PostAsync(uri,content);
        }

    }
}

