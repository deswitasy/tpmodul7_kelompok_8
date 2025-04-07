using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tpmodul7_kelompok_8
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }

    }

    public class DataMahasiswa
    {
        public Nama nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }
    internal class DataMahasiswa103022300116
    {
        public static void ReadJSON()
        {
            string filePath = "tp7_1_103022300116.json";
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    DataMahasiswa mhs = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

                    if (mhs != null && mhs.nama != null)
                    {
                        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim}, dari fakultas {mhs.fakultas}");
                    }
                    else
                    {
                        Console.WriteLine("Data JSON tidak lengkap atau tidak sesuai format.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Terjadi kesalahan saat memproses file JSON:");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan!");
            }
        }

    }
}
