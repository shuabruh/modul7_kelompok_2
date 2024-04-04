using System;

namespace DataMahasiswa
{
    public class DataMahasiswa1302220085
    {
        
        public class address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class data
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public address address { get; set; }
            public List<courses> mataKuliah { get; set; }

        }
    }
}

