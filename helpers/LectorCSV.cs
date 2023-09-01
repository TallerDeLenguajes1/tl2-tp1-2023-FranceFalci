using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EspacioCadete;

namespace LectorCSV
{
  static public class HelperCsv
  {
    public static List<string[]> LeerCsv(string rutaDeArchivo, string nombreDeArchivo, char caracter)
    {
      FileStream MiArchivo = new FileStream(rutaDeArchivo + nombreDeArchivo, FileMode.Open);
      StreamReader StrReader = new StreamReader(MiArchivo);

      string Linea = "";
      List<string[]> LecturaDelArchivo = new List<string[]>();

      while ((Linea = StrReader.ReadLine()) != null)
      {
        string[] Fila = Linea.Split(caracter);
        LecturaDelArchivo.Add(Fila);
      }

      return LecturaDelArchivo;
    }

  }

  public class Conversor
  {
    public List<Cadete> ConversorDeCadete(List<string[]> Filas)
    {

      List<Cadete> listaCadetes = new List<Cadete>();
      foreach (string[] fila in Filas)
      {
        Cadete cadete = new Cadete(Convert.ToInt32(fila[0]), fila[1], Convert.ToInt32(fila[2]), fila[3]);
        listaCadetes.Add(cadete);
      }
      return listaCadetes;

    }

  }
}