namespace Datos.Controllers;

    public class MySQLConfigutation
    {
    public string CadenaConexion { get; }

    public MySQLConfigutation(string codenaConexion)
    {
        CadenaConexion = codenaConexion;
    }
}
