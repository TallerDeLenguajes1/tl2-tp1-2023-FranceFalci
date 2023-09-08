using EspacioPedido;
using System.Linq;
using EspacioCliente;

namespace EspacioCadete;

public class Cadete
{
  private int id;
  private String nombre;
  private int telefono;
  private String direccion;


  public int Id { get => id; set => id = value; }
  public string Nombre { get => nombre; set => nombre = value; }

  public Cadete(int id, string nombre, int telefono, string direccion)
  {
    this.id = id;
    this.Nombre = nombre;
    this.telefono = telefono;
    this.direccion = direccion;
  }


  // public void crearPedido(int nroPedido, string obs, Cliente cliente, estado estado)
  // {
  //   var nuevoPedido = new Pedido(cliente, nroPedido, obs, estado);
  //   listaPedidos.Add(nuevoPedido);

  // }

  // public void eliminarPedido(int nroPedido)
  // {
  //   listaPedidos = listaPedidos.Where(pedido => pedido.NroPedido != nroPedido).ToList();
  // }

  // public void cambiarEstado(int nroPedido, estado nuevoEstado)
  // {
  //   var pedido = listaPedidos.FirstOrDefault(pedido => pedido.NroPedido == nroPedido);
  //   pedido.Estado = nuevoEstado;

  // }
}

