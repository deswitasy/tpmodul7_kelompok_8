using System;
using System.IO;
using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class DataMahasiswa103022300004
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        string filePath = "tp7_1_103022300004.json";
        string json = File.ReadAllText(filePath);

        DataMahasiswa103022300004 data = JsonSerializer.Deserialize<DataMahasiswa103022300004>(json);

        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}

