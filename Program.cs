using LectorCSV;
using EspacioCadete;
using EspacioCadeteria;
using EspacioMenu;
internal class Program
{
  private static void Main(string[] args)
  {

    string nombreDeArchivo = "cadetes.csv";
    string rutaDeArchivo = @"./csv/";

    List<string[]> LecturaDelArchivo = HelperCsv.LeerCsv(rutaDeArchivo, nombreDeArchivo, ',');
    var conversor = new Conversor();
    Cadeteria cadeteriaA = new Cadeteria("cadeteriaA", 123);
    cadeteriaA.ListaCadetes = conversor.ConversorDeCadete(LecturaDelArchivo);
    cadeteriaA.listarCadetes();

    RunMenuPrincipal();
    void RunMenuPrincipal()
    {
      string[] options = { "Dar alta pedido", "asignar cadete", "cambiar estado pedido", "SALIR" };
      Menu menuPrincipal = new Menu(options, "CADETERIA");
      int seleccionMenuPrincipal = menuPrincipal.Run();

      switch (seleccionMenuPrincipal)
      {
        case 0:
          Console.WriteLine("dar alta pedido");
          break;
        case 1:
          Console.WriteLine("asignar cadete");
          break;
        case 2:
          Console.WriteLine("dar alta pedido");
          break;
        case 3:
          Console.WriteLine("dar alta pedido");
          break;

      }
    }

  }
}