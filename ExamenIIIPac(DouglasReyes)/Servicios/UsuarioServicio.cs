using Datos.Interfaces;
using Datos.Repositorios;
using ExamenIIIPac_DouglasReyes_.Data;
using ExamenIIIPac_DouglasReyes_.Interfaces;
using Modelos;

namespace ExamenIIIPac_DouglasReyes_.Servicios;

public class UsuarioServicio : IUsuarioServicio
{
    private readonly MySQLConfigutation _configuration;
    private IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(MySQLConfigutation configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }

    public async Task<bool> Actualizar(Usuario usuarios)
    {
        return await usuarioRepositorio.Actualizar(usuarios);
    }

    public async Task<bool> Eliminar(Usuario usuarios)
    {
        return await usuarioRepositorio.Eliminar(usuarios);
    }

    public async Task<IEnumerable<Usuario>> GetLista()
    {
        return  await usuarioRepositorio.GetLista();
    }

    public async Task<Usuario> GetPorCodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorCodigo(codigo);
    }

    public async Task<bool> Nuevo(Usuario usuarios)
    {
        return await usuarioRepositorio.Nuevo(usuarios);
    }
}

