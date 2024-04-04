using System.Text.Json;
using DataMahasiswa;

internal class Program
{
    private static void Main(string[] args)
    {
        readJSON();
    }
    private static void readJSON()
    {
        string filepath = Path.Combine(@"C:\Users\delll\Downloads\New folder\jurnal7_1_1302220131.json");
        string jsonFile = File.ReadAllText(filepath);
        Datamahasiswa_1302220131 data = JsonSerializer.Deserialize<Datamahasiswa_1302220131>(jsonFile);

        Console.WriteLine(value: "Nama : " + data.nama.firstName + " " + data.nama.lastName);
        Console.WriteLine("Gender: " + data.gender);
        Console.WriteLine("Age: " + data.gender);
        Console.WriteLine(value: "Address: " + data.address.streetAddress + " " + data.address.city + " " + data.address.state);
        Console.WriteLine(value: "Courses: " + data.courses.code + " " + data.courses.name);
    }
}
