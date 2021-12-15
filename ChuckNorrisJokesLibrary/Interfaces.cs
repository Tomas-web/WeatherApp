using ChuckNorrisJokesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary
{
    public interface IJokesDataProvider
    {
        Joke GetRandom();

        Joke GetRandomInCategory(string category);

        IEnumerable<string> GetCategories();

        IEnumerable<Joke> FindByName(string q);
    }
}
