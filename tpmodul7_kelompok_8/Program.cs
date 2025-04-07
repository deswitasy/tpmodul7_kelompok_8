// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using tpmodul7_kelompok_8;

class Program
{
    
    static void Main(string[] args)
    {
        DataMahasiswa103022300116.ReadJSON();
        var mahasiswa = new datamahasiswa_103022300052_apriliani();
        mahasiswa.ReadJSON();
        kuliahmahasiswa_103022300052 read = new kuliahmahasiswa_103022300052();
        read.ReadJSONList();
       
        Console.ReadKey();
      
    }

}
