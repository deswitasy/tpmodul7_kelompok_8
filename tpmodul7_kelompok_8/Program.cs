// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;
using tpmodul7_kelompok_8;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300004 obj = new DataMahasiswa103022300004();
        obj.ReadJSON();
        KuliahMahasiswa103022300004.ReadJSON();

    }

}

    public static void Main()
    {

        DataMahasiswa103022300116.ReadJSON();
        KuliahMahasiswa103022300116.ReadJSON();
    }
}