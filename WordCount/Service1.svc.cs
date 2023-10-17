using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace WordCount
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1
    {
        public string wordCount(string contents)
        {
            string[] words = null;
            string json = null;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            char[] delims = {' ', ',', '.', '!', ';', ':', '?', '\n', '\t', '\r'};
            
            // split string using delimiters and store each word in string array
            words = contents.Split(delims);

            // count the occurences of each word
            foreach (string word in words)
            {
                if (word != "")
                {
                    if (dict.ContainsKey(word)) dict[word]++;
                    else dict[word] = 1;
                }
            }
                
            // sort each word in descending order by number of occurences
            var ordered = from k in dict.Keys
                          orderby dict[k] descending
                          select k;

            // json = JsonConvert.SerializeObject(dict);
            // convert to json string
            foreach (string k in ordered)
            {
                json += string.Format("\"{0}\": {1}, ", k, dict[k]);
            }
            
            json = json.Remove(json.Length - 2, 2);     // remove trailing comma and space
            json = "{ " + json + " }";

            return json;
        }
    }
}
