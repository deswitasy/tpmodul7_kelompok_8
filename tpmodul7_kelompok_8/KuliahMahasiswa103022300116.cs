using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_8
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class KuliahMahasiswa103022300116
    {
        public List<Course> courses { get; set; }

        public static void ReadJSON()
        {
            string filePath = "tp7_2_103022300116.json";
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    KuliahMahasiswa103022300116 data = JsonSerializer.Deserialize<KuliahMahasiswa103022300116>(jsonString);

                    if (data != null && data.courses != null)
                    {

                        Console.WriteLine("Daftar mata kuliah yang diambil:");
                        for (int i = 0; i < data.courses.Count; i++)
                        {
                            Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Data kosong");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error saat membaca atau parsing JSON:");
                    Console.WriteLine(e.Message);
                }

            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }
        }
    }
}
