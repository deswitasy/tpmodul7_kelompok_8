using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_8
{
    public class matkul_103022300052
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class kuliahmahasiswa_103022300052
    {
        public List<matkul_103022300052> courses { get; set; }

        public void ReadJSONList()
        {
            try
            {
                // Baca file JSON
                string json = File.ReadAllText("tp7_2_103022300052.json");

                // Deserialize JSON ke object
                kuliahmahasiswa_103022300052 data = JsonConvert.DeserializeObject<kuliahmahasiswa_103022300052>(json);

                // Tampilkan hasil deserialisasi
                Console.WriteLine("Daftar Mata Kuliah:");
                foreach (var m in data.courses)
                {
                    Console.WriteLine($"Kode: {m.code}, Nama: {m.name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error saat membaca JSON: {ex.Message}");
            }
        }
    }
}
