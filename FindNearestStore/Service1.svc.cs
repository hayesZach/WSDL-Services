using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace FindNearestStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string findNearestStore(string zipcode, string name)
        {
            Store store = new Store();
            Coordinates coords = new Coordinates();
            string address, storeName, result;
            string key = "AIzaSyC0zkefCU3KGjnTtAXeI6eP7WgueJfiJ8I";
            string url = "https://maps.googleapis.com/maps/api/geocode/json?components=postal_code:" + zipcode + "&sensor=false&key=" + key;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string json = reader.ReadToEnd();
            reader.Close();

            coords = JsonConvert.DeserializeObject<Coordinates>(json);

            // if we were able to get a valid response from the API 
            if (coords.status == "OK")
            {
                // get location from coords object "lat,lng"
                string location = coords.results[0].geometry.location.lat.ToString() + ',' + coords.results[0].geometry.location.lng.ToString();
                url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + location + "&rankby=distance&keyword=" + name + "&key=" + key;
                request = WebRequest.Create(url);
                response = request.GetResponse();
                data = response.GetResponseStream();
                StreamReader reader2 = new StreamReader(data);
                json = reader2.ReadToEnd();
                store = JsonConvert.DeserializeObject<Store>(json);
                if (store.status == "OK")
                {
                    address = store.results[0].vicinity;
                    storeName = store.results[0].name;
                    result = storeName + ": " + address;
                }
                else result = "no stores within zipcode";
            }
            else result = "invalid zipcode";
     
            return result;
        }
    }
}
