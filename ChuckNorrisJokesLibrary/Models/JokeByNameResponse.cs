using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary.Models
{
    class JokeByNameResponse
    {
        public int total;
        public IEnumerable<Joke> result;

        public IEnumerable<Joke> GetResult()
        {
            return result;
        }
    }
}
