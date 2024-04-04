using System.Text.Json;

namespace DataMahasiswa_1302220072
{
    public class DataMahasiswa1302220072
    {
        public string firstName { get;set; }
        public string lastName { get;set; }
        public string gender { get;set; }
        public int age { get;set; }
        public Address address { get;set; }
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = @"jurnal7_1_1302220072.json";
            string jsonData = File.ReadAllText(filePath);
            DataMahasiswa1302220072 data = new DataMahasiswa1302220072();
            data.courses = new List<Courses>();
            data.address = new Address();
            data = JsonSerializer.Deserialize<DataMahasiswa1302220072>(jsonData);

            Console.WriteLine("Nama: " + data.firstName + " " + data.lastName);
            Console.WriteLine("Gender: " + data.gender);
            Console.WriteLine("Umur: " + data.age);
            Console.WriteLine("Alamat: " + "\n" + data.address.streetAddress);
            Console.WriteLine("Kota: " + data.address.city);
            Console.WriteLine("Provinsi: " + data.address.state);
            Console.WriteLine("Mata kuliah: ");
            for(int i = 0; i < data.courses.Count; i++)
            { 
                Console.WriteLine("Mata kuliah " + (i+1) + " - " + data.courses[i].code + " - " + data.courses[i].name);
            }
        }
    }

    public class Address
    {
        public string streetAddress { get;set; }
        public string city { get;set; }
        public string state { get;set; }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}