namespace FindNearestStore
{
    // not sure if there's a better way to get specified fields from json string than creating a bunch of nested objects
    // each object MUST have the same name as the corresponding key in the json string
    // use this class to deserialize json string
    public class Store
    {
        public Result[] results { get; set; }   // must be an array
        public string status { get; set; }

        public class Result
        {
            public string name { get; set; }
            public string vicinity { get; set; }
        }
    }
}