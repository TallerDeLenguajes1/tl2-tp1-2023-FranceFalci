using LectorCSV;
using EspacioCadete;
using EspacioCadeteria;
using EspacioMenu;
using EspacioCliente;
internal class Program
{
  private static void Main(string[] args)
  {

    int nroPedido = 0;
    string nombreDeArchivo = "cadetes.csv";
    string rutaDeArchivo = @"./csv/";

    List<string[]> LecturaDelArchivo = HelperCsv.LeerCsv(rutaDeArchivo, nombreDeArchivo, ',');
    var conversor = new Conversor();
    Cadeteria cadeteriaA = new Cadeteria("cadeteriaA", 123);
    cadeteriaA.ListaCadetes = conversor.ConversorDeCadete(LecturaDelArchivo);
    // cadeteriaA.listarCadetes();
    // var cliente = new Cliente("france", "america al 2000", 3999, "frente esc");

    // cadeteriaA.crearPedido("france", "av amrica", 123456, "frente esc", 1, "obs1");


    // cadeteriaA.listarPedidos();

    // cadeteriaA.crearPedido(2, "obs1", cliente, EspacioPedido.estado.pendiente);
    // cadeteriaA.crearPedido(3, "obs1", cliente, EspacioPedido.estado.pendiente);
    RunMenuPrincipal();



    void RunMenuPrincipal()
    {
      string[] options = { "Dar alta pedido", "asignar cadete", "cambiar estado pedido", "listar pedidos", "listar cadetes", "SALIR" };
      Menu menuPrincipal = new Menu(options, "CADETERIA");
      int seleccionMenuPrincipal = menuPrincipal.Run();

      switch (seleccionMenuPrincipal)
      {
        case 0:
          darAltaPedido();
          RunMenuPrincipal();
          botonVolver();


          break;
        case 1:
          AsignarPedido();
          RunMenuPrincipal();
          botonVolver();


          break;
        case 2:
          cambiarEstado();
          RunMenuPrincipal();
          botonVolver();


          break;
        case 3:
          cadeteriaA.listarPedidos();
          botonVolver();

          break;
        case 4:
          cadeteriaA.listarCadetes();
          botonVolver();


          break;

      }
    }

    void darAltaPedido()
    {
      nroPedido++;
      Console.WriteLine("ingrese nombre cliente : ");
      string nombre = Console.ReadLine();
      Console.WriteLine("ingrese direccion : ");
      string direccion = Console.ReadLine();
      cadeteriaA.crearPedido(nombre, direccion, 123456, "frente esc", nroPedido, "obs1");
      cadeteriaA.listarPedidos();


    }

    void AsignarPedido()
    {
      Console.WriteLine("Por favor, ingrese id cadete:");
      string input = Console.ReadLine(); // Lee una línea de texto desde la consola

      if (int.TryParse(input, out int idCadete))
      {
        Console.WriteLine("Por favor, ingrese num pedido:");
        input = Console.ReadLine(); // Lee una línea de texto desde la consola

        if (int.TryParse(input, out int numPedido))
        {
          cadeteriaA.AsignarPedido(numPedido, idCadete);
        }
        else
        {
          Console.WriteLine("No ingresaste un número entero válido.");
        }
      }
      else
      {
        Console.WriteLine("No ingresaste un número entero válido.");
      }

    }

    void cambiarEstado()
    {

      int cantidadPedidos = cadeteriaA.cantidadPedidos();
      string[] options = new string[cantidadPedidos]; ;
      for (int i = 0; i < cantidadPedidos; i++)
      {
        options[i] = (i + 1).ToString(); // Agregar números como cadenas al arreglo

      }
      Menu menuPrincipal = new Menu(options, "CADETERIA");
      int numPedido = menuPrincipal.Run();
      listarEstados(numPedido);
      // Console.WriteLine("Por favor, ingrese num pedido:");
      // string input = Console.ReadLine(); // Lee una línea de texto desde la consola

      // if (int.TryParse(input, out int numPedido))
      // {
      // }
    }

    void listarEstados(int numPedido)
    {
      string[] options = { "pendiente", "entregado", "cancelado", "SALIR" };
      Menu menuPrincipal = new Menu(options, "CAMBIAR ESTADO");
      int seleccionMenuPrincipal = menuPrincipal.Run();

      switch (seleccionMenuPrincipal)
      {
        case 0:
          cadeteriaA.cambiarEstado(numPedido, EspacioPedido.estado.pendiente);
          break;
        case 1:
          cadeteriaA.cambiarEstado(numPedido, EspacioPedido.estado.entregado);
          botonVolver();


          break;
        case 2:
          cadeteriaA.cambiarEstado(numPedido, EspacioPedido.estado.cancelado);
          botonVolver();


          break;
      }


    }
    void botonVolver()
    {
      ConsoleKey teclaPres;

      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      Console.WriteLine("Volver");
      Console.ResetColor();
      do
      {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        teclaPres = keyInfo.Key;

        if (teclaPres == ConsoleKey.Enter)
        {
          RunMenuPrincipal();

        }
      } while (teclaPres != ConsoleKey.Enter);
    }

  }

}