using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


namespace URL_Shortener
{
    public class UrlService
    {
        private static readonly HttpClient httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        // validate url
        public static bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uri)
                   && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
        }

        // using tiny url service
        public async Task<string> ShortenAsync(string longUrl, CancellationToken ct = default)
        {
            longUrl = (longUrl ?? "").Trim();

            if (string.IsNullOrEmpty(longUrl))
                throw new ArgumentException("Please enter a URL.");

            if (!IsValidUrl(longUrl))
                throw new ArgumentException("Invalid URL. It must start with http:// or https://");

            string apiUrl = "https://tinyurl.com/api-create.php?url=" + Uri.EscapeDataString(longUrl);

            using (HttpResponseMessage response = await httpClient.GetAsync(apiUrl, ct))
            {
                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException(
                        $"TinyURL returned an error ({(int)response.StatusCode} {response.ReasonPhrase}).");

                string shortUrl = (await response.Content.ReadAsStringAsync()).Trim();

                if (!IsValidUrl(shortUrl))
                    throw new InvalidOperationException("TinyURL returned an unexpected response.");

                return shortUrl;


            }
        }
    }
}
