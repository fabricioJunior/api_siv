using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using infra.Common;
using infra.DataTransferObjects;

namespace infra.RemoteDataAccess
{
	public class NFCWebManiaRemoteDataSource: HttpClientBase
	{

		private readonly string uri = "https://webmaniabr.com/api//1/nfe/emissao/";


        public NFCWebManiaRemoteDataSource()
		{
		}


		public string PostNFC(NFC nfc) {

			var json = JsonSerializer.Serialize(nfc);
			var task = Post(uri, json);
			task.Wait();
			var response = task.Result;
			if (response.StatusCode != System.Net.HttpStatusCode.Created)
			{
				throw new Exception(response.ToString());
			}
			var resultJsonTask = response.Content.ReadAsStringAsync();
			resultJsonTask.Wait();
			var resultJson = resultJsonTask.Result;
            var webManiaNfcResult = JsonSerializer.Deserialize<WebManiaNFCResult>(resultJson);

			return webManiaNfcResult.Danfe;
        }
	}
}

