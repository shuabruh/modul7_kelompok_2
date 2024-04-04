using System;
using System.Text.Json;

namespace modul7_kelompok_2
{
	public class DataMahasiswa1302223118_Rakha
	{
        public class Address
        {
            public string jalan { get; set; }
            public string kota { get; set; }
            public string provinsi { get; set; }
        }
        public class Courses
        {
            public String code { get; set; }
            public String name { get; set; }
        }
        public class Data
        {
            public string namaDepan { get; set; }
            public string namaBelakang { get; set; }
            public string gender { get; set; }
            public int umur { get; set; }
            public Address alamat { get; set; }
            public Courses kursus { get; set; }
        }
        public static void readJSON()
        {
            string filepath = "../../../jurnal7_1_1302223118.json";
            string jsonFile = File.ReadAllText(filepath);
            DataMahasiswa1302223118_Rakha.Data data = JsonSerializer.Deserialize<DataMahasiswa1302223118_Rakha.Data>(jsonFile);
            Console.WriteLine("Nama :" + data.namaDepan+ " " + data.namaBelakang);
            Console.WriteLine("Nim :" + data.umur);
            Console.WriteLine("Fakultas :" + data.gender);
            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}