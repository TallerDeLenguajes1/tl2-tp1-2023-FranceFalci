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

  public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }

  public Cadeteria(string nombre, int telefono)
  {
    this.telefono = telefono;
    this.nombre = nombre;
  }
  public void crearPedido(int nroPedido, string obs, Cliente cliente, estado estado, int idCadete)
  {
    var cadete = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
    cadete.crearPedido(nroPedido, obs, cliente, estado);
    // foreach (Cadete cadete in listaCadetes)
    // {
    //   if (cadete.Id == idCadete)
    //   {
    //     cadete.crearPedido(nroPedido, obs, cliente, estado);


    //   }
    // }
  }

  public void reasignarPedido(int idCadeteActual, int idNuevoCadete, Pedido pedido)
  {
    var cadeteActual = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idCadeteActual);
    var nuevoCadete = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idNuevoCadete);
    nuevoCadete.crearPedido(pedido.NroPedido, pedido.Observacion, pedido.Cliente, pedido.Estado);
    cadeteActual.eliminarPedido(pedido.NroPedido);
    // cadete.crearPedido(nroPedido, obs, cliente, estado);
  }

  public void cambiarEstado(int nroPedido, estado nuevoEstado, int idCadete)
  {
    var cadete = ListaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
    cadete.cambiarEstado(nroPedido, nuevoEstado);
  }
  public void listarCadetes()
  {
    foreach (var cadete in listaCadetes)
    {
      Console.WriteLine(cadete.Nombre);
    }
  }
}

// var filteredOrders = orders.Where(order => order.Estado == 1);
