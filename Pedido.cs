namespace EspacioPedido;
using EspacioCliente;

public class Pedido
{
  private int nroPedido;
  private String observacion;
  private Cliente cliente;

  private estado estado;

  public estado Estado { get => estado; set => estado = value; }
  public Cliente Cliente { get => cliente; set => cliente = value; }
  public string Observacion { get => observacion; set => observacion = value; }
  public int NroPedido { get => nroPedido; set => nroPedido = value; }


  public Pedido(Cliente cliente, int nroPedido, string obs, estado estado)
  {
    this.cliente = cliente;
    this.nroPedido = nroPedido;
    this.observacion = obs;
    this.estado = 0;
  }
  public String verDireccionCliente()
  {
    return Cliente.Direccion;
  }

  public String VerDatosCliente()
  {
    return Cliente.Nombre + " " + Cliente.Telefono;
  }

}

public enum estado
{
  pendiente,
  entregado,
  cancelado
}