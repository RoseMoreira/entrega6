using Agencia.Model;

namespace Agencia.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        void AddUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void DeletarUsuario(Usuario usuario);
        
        Task<bool> SaveChangesAsync();
        Task GetUsuarioById(int v, object id);
        Task GetUsuarioById(object id);
    }
}