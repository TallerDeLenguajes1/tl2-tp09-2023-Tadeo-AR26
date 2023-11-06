using espacioKanban;
namespace espacioRepositories;

public interface IUsuarioRepository{
    public List<Usuario> GetAllUsuarios();
    public Usuario GetUsuarioByID(int id);
    public bool CreateUsuario(Usuario usuario);
    public bool RemoveUsuario(int id);
    public bool UpdateUsuario(Usuario usuario);
}