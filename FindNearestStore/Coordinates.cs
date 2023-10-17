namespace FindNearestStore
{
    // not sure if there's a better way to get specified fields from json string than creating a bunch of nested objects
    // each object MUST have the same name as the corresponding key in the json string
    // use this class to deserialize json string
    public class Coordinates
    {
        public Result[] results { get; set; }   // must be an array
        public string status { get; set; }

        public class Result
        {
            public Geometry geometry { get; set; }
            public class Geometry
            {
                public Location location { get; set; }
                public class Location
                {
                    public string lat { get; set; }
                    public string lng { get; set; }
                }
            }
        }
    }
}