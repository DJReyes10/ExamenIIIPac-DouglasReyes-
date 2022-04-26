
using Modelos;

namespace ExamenIIIPac_DouglasReyes_.Interfaces;

    public interface IUsuarioServicio
    {
        Task<bool> Nuevo(Usuario usuarios);
        Task<bool> Actualizar(Usuario usuarios);
        Task<bool> Eliminar(Usuario usuarios);
        Task<IEnumerable<Usuario>> GetLista();
        Task<Usuario> GetPorCodigo(string codigo);
    }

