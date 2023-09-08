using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using EspacioCadete;
namespace EspacioJSON;

public class PersonajeJson
{
  public void GuardarPersonajes(List<Cadete> listaCadetes, string path)
  {
    string json = JsonSerializer.Serialize(listaCadetes);
    File.WriteAllText(path, json);
  }

  public List<Cadete> LeerPersonajes(string path)
  {

    string jsonString = File.ReadAllText(path);
    List<Cadete>? listaCadetes = JsonSerializer.Deserialize<List<Cadete>>(jsonString);

    if (listaCadetes == null) listaCadetes = new List<Cadete>();

    return listaCadetes;
  }

  public bool ExisteArchivo(string path)
  {
    if (File.Exists(path))
    {
      string contenido = File.ReadAllText(path);
      return !string.IsNullOrEmpty(contenido);
    }
    // if (File.Exists(path))
    // {
    //     FileInfo fileInfo = new FileInfo(path);
    //     return fileInfo.Length > 0;
    // }

    return false;
  }




}