using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class KuliahMahasiswa103022300004
    {
        public List<Course> courses { get; set; }

        public static void ReadJSON()
        {
            string filePath = "tp7_2_103022300004.json";
            string json = File.ReadAllText(filePath);
            KuliahMahasiswa103022300004 data = JsonSerializer.Deserialize<KuliahMahasiswa103022300004>(json);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }

}
