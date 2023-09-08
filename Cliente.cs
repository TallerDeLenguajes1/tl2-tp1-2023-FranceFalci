namespace EspacioCliente;
public class Cliente
{
  private String nombre;
  private String direccion;
  private int telefono;
  private String direccionDeReferencia;

  public Cliente(string nombre, string direccion, int telefono, string direccionDeReferencia)
  {
    this.nombre = nombre;
    this.direccion = direccion;
    this.telefono = telefono;
    this.direccionDeReferencia = direccionDeReferencia;
  }

  public string Direccion { get => direccion; set => direccion = value; }
  public string Nombre { get => nombre; set => nombre = value; }
  public string DireccionDeReferencia { get => direccionDeReferencia; set => direccionDeReferencia = value; }
  public int Telefono { get => telefono; set => telefono = value; }
}
