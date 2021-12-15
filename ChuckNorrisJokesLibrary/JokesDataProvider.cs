using ChuckNorrisJokesLibrary;
using ChuckNorrisJokesLibrary.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChuckNorrisJokes
{
    public class JokesDataProvider : IJokesDataProvider
    {
        private RestClient m_client;

        public JokesDataProvider()
        {
            m_client = new RestClient("https://api.chucknorris.io/jokes");
            m_client.Timeout = -1;
        }

        public IEnumerable<Joke> FindByName(string q)
        {
            var request = new RestRequest($"/search?query={q}", Method.GET);
            var response = m_client.Get(request);
            Console.WriteLine(response.Content);
            return JsonConvert.DeserializeObject<JokeByNameResponse>(response.Content).GetResult();
        }

        public IEnumerable<string> GetCategories()
        {
            var request = new RestRequest("/categories", Method.GET);
            var response = m_client.Get(request);

            return JsonConvert.DeserializeObject<IEnumerable<string>>(response.Content);
        }

        public Joke GetRandom()
        {
            var request = new RestRequest("/random", Method.GET);
            var response = m_client.Get(request);

            return JsonConvert.DeserializeObject<Joke>(response.Content);
        }

        public Joke GetRandomInCategory(string category)
        {
            var request = new RestRequest($"/random?category={category}", Method.GET);
            var response = m_client.Get(request);

            return JsonConvert.DeserializeObject<Joke>(response.Content);
        }
    }
}
