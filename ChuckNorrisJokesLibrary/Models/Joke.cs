using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary.Models
{
    public class Joke
    {
        public string id;
        public string value;
        public IEnumerable<string> categories;
        public string icon_url;
        public string url;
        public string updated_at;
        public string created_at;

        public string GetId()
        {
            return id;
        }

        public string GetValue()
        {
            return value;
        }

        public string GetIconUrl()
        {
            return icon_url;
        }


        /* 
         {
        "categories":["animal"],
        "created_at":"2020-01-05 13:42:19.576875",
        "icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png",
        "id":"bmom6jqftpqgokh8adtolw",
        "updated_at":"2020-01-05 13:42:19.576875",
        "url":"https://api.chucknorris.io/jokes/bmom6jqftpqgokh8adtolw",
        "value":"Chuck Norris once rode a nine foot grizzly bear through an automatic car wash, instead of taking a shower."
        }
         */
    }
}
