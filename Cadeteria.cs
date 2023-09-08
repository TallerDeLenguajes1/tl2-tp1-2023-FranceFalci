using System.Data;
using EspacioCadete;
using EspacioCliente;
using EspacioPedido;

namespace EspacioCadeteria;

public class Cadeteria
{
  private string nombre;
  private int telefono;

  List<Cadete> listaCadetes;
  List<Pedido> listaPedidos;
  public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }

  public Cadeteria(string nombre, int telefono)
  {
    this.telefono = telefono;
    this.nombre = nombre;
    this.listaPedidos = new List<Pedido>();
  }
  public void crearPedido(string nombre, string direccion, int telefono, string dirReferencia, int nroPedido, string obs)
  {
    var nuevoPedido = new Pedido(nombre, direccion, telefono, dirReferencia, nroPedido, obs);
    listaPedidos.Add(nuevoPedido);
  }

  public void AsignarPedido(int nroPedido, int idCadete)
  {
    var pedido = listaPedidos.FirstOrDefault(pedido => pedido.NroPedido == nroPedido);
    var cadete = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
    pedido.IdCadete = cadete.Id;
  }

  public int cantidadPedidos()
  {
    return listaPedidos.Count();
  }

  public void reasignarPedido(int nroPedido, int idNuevoCadete)
  {
    var nuevoCadete = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idNuevoCadete);
    var pedido = listaPedidos.FirstOrDefault(pedido => pedido.NroPedido == nroPedido);
    pedido.IdCadete = nuevoCadete.Id;

  }

  public void cambiarEstado(int nroPedido, estado nuevoEstado)
  {
    // var cadete = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
    // cadete.cambiarEstado(nroPedido, nuevoEstado);
    var pedido = listaPedidos.FirstOrDefault(pedido => pedido.NroPedido == nroPedido);
    pedido.Estado = nuevoEstado;
  }
  public void listarCadetes()
  {
    foreach (var cadete in listaCadetes)
    {
      Console.WriteLine(cadete.Nombre);
    }
  }

  public void listarPedidos()
  {
    foreach (var pedido in listaPedidos)
    {
      // Console.WriteLine();

      // cadeteriaA.listarCadetes();
      Console.WriteLine("nro pedido:  {0}", pedido.NroPedido);
      if (pedido.IdCadete == 0)
      {
        Console.WriteLine("cadete sin asignar");

      }
      else
      {
        Console.WriteLine("id Cadete: {0}", pedido.IdCadete);
      }
      Console.WriteLine("estado: {0}", pedido.Estado);
      Console.WriteLine("CLiente: {0}", pedido.Cliente.Nombre);
      Console.WriteLine("dir CLiente: {0}", pedido.Cliente.Direccion);

      Console.WriteLine("-----------------");

    }
  }
}

// var filteredOrders = orders.Where(order => order.Estado == 1);
