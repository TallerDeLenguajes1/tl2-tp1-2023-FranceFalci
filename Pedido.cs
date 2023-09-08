namespace EspacioPedido;

using EspacioCadete;
using EspacioCliente;

public class Pedido
{
  private int nroPedido;
  private String observacion;
  private Cliente cliente;

  private int idCadete;

  private estado estado;

  public estado Estado { get => estado; set => estado = value; }
  public string Observacion { get => observacion; set => observacion = value; }
  public int NroPedido { get => nroPedido; set => nroPedido = value; }
  public int IdCadete { get => idCadete; set => idCadete = value; }
  public Cliente Cliente { get => cliente; set => cliente = value; }

  public Pedido(string nombre, string direccion, int telefono, string dirReferencia, int nroPedido, string obs)
  {
    var cliente = new Cliente(nombre, direccion, telefono, dirReferencia);
    this.Cliente = cliente;
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