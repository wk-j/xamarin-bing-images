using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;

namespace BingImages.Shared
{
	public class BingHelper
	{

		public List<BingImage> Images { get; set;}
		public BingHelper ()
		{
			Images = new List<BingImage> ();
		}

		private BingImage CreateImage (Dictionary<string, object> obj)
		{
			var artwork = obj ["artwork_url"] as string;
			return new BingImage {
				SourceUrl = artwork,
				MediaUrl = artwork,
				Title = obj["title"] as string
			};
		}

		public async Task<bool> QuerySoundClound (string query)
		{
			var url = "http://api.soundcloud.com/users/67393202/tracks.json?client_id=0be8085a39603d77fbf672a62a7929ea";
			var handler = new HttpClientHandler { };
			var client = new HttpClient (handler);
			var result = await client.GetStringAsync (url);
			if (string.IsNullOrEmpty (result)) return false;

			var obj = JsonConvert.DeserializeObject <List<Dictionary<string, Object>>> (result).Select(CreateImage).Where(x => x.Title.Contains(query)).ToList ();
			Images = obj;

			return true;
		}

		public async Task<bool> QueryBingImages(string query)
		{
			var bingQuery = string.Format ("https://api.datamarket.azure.com/Bing/Search/v1/Image?Query=%27{0}%27&Adult=%27Strict%27&ImageFilters=%27Size%3AMedium%27&$format=json", query);
			var handler = new HttpClientHandler {
				Credentials = new System.Net.NetworkCredential(key, key)
			};
			var client = new HttpClient (handler);
			var result = await client.GetStringAsync (bingQuery);

			if (string.IsNullOrWhiteSpace (result))
				return false;

			Images = JsonConvert.DeserializeObject<BingQuery> (result).Query.Results;

			return true;
		}

		private const string key = "eXnbJoi4TyPYfitCtmnbDX3/xWsSgU2NfA9l8/G4JFU=";

	}
}

