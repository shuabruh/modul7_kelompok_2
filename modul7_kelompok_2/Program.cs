using System.Text.Json;
using DataMahasiswa;

internal class Program
{
    public static void Main(string[] args)
    {
        ReadJSON();
    }

    public static void ReadJSON()
    {
        string filepath = Path.Combine(@"D:\1302220085_MOD7_JURNAL_RMR\modul7_kelompok_2\modul7_kelompok_2\jurnal7_1_1302220085.json");
        string jsonfile = File.ReadAllText(filepath);
        DataMahasiswa1302220085.data data = JsonSerializer.Deserialize<DataMahasiswa1302220085.data>(jsonfile);
        List<DataMahasiswa1302220085.courses> listMK = new List<DataMahasiswa1302220085.courses>();

        Console.WriteLine("Nama :   " + data.firstName + " " + data.lastName);
        Console.WriteLine("Gender : " + data.gender);
        Console.WriteLine("Umur :   " + data.age);
        Console.WriteLine("Alamat : " + data.address.streetAddress);
        Console.WriteLine("         " + data.address.city);
        Console.WriteLine("         " + data.address.state);

        foreach (DataMahasiswa1302220085.courses objMK in listMK)
        {
            listMK.Add(objMK);
        }

        for (int i = 0; i < listMK.Count; i++)
        {
            Console.WriteLine("Mata Kuliah : " + data.mataKuliah);
        }
    }
}