using System;
using System.Text.Json;
using static modul7_kelompok_2.DataMahasiswa1302223118_Rakha;

namespace modul7_1302223118
{
    public class TeamMember1302223118_Rakha
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public String nim { get; set; }

        }

        public List<Member> members { get; set; }


        public static void readJSON()
        {
            string filepath = "../../../jurnal7_2_1302223118.json";
            string jsonFile = File.ReadAllText(filepath);
            TeamMember1302223118_Rakha data = JsonSerializer.Deserialize<TeamMember1302223118_Rakha>(jsonFile);
            int i = 1;
            foreach (var member in data.members)
            {

                Console.WriteLine($"{i} - <{member.nim}> <{member.firstName} + {member.lastName}>" +
                    $" (<{member.age}><{member.gender}");
                i++;
            }
        }
    }
}
