using Bully.Models.Movie;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bully.Services.Facade
{
    public class MovieFacade
    {
        HttpClient client;

        public MovieFacade()
        {
            this.client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }


        public async Task<ListMovieResponse> MovieLast()
        {
            var url = new Uri(string.Format(CultureInfo.InvariantCulture, Constants.UrlsConstants.TopRatedMoviesKey));
            var result = await client.GetAsync(url);
            if (result.IsSuccessStatusCode)
            {
                string content = await result.Content.ReadAsStringAsync();
                if (content != null)
                {
                    var response = JsonConvert.DeserializeObject<ListMovieResponse>(content);
                    response.isCorrect = true;
                    return response;

                }
                return new ListMovieResponse() { isCorrect = false, mensage = "No hay datos que mostrar" };
            }
            return new ListMovieResponse() { isCorrect = false, mensage = result.ReasonPhrase };
        }
    }
}
