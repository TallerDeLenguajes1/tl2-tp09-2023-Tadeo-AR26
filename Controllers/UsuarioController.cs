using espacioKanban;
using espacioRepositories;
using Microsoft.AspNetCore.Mvc;
namespace espacioControllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase{
    private readonly ILogger<UsuarioController> _logger;
    private UsuarioRepository repository = new UsuarioRepository();
    public UsuarioController(ILogger<UsuarioController> logger){
        _logger = logger;
    }

    [HttpPost("api/usuario/{usuario}")]
    public ActionResult<Usuario> CreateUsuario(Usuario usuario){
        return Ok(repository.CreateUsuario(usuario));
    }

    [HttpGet("api/usuario")]
    public ActionResult<List<Usuario>> GetAllUsuarios(){
        return Ok(repository.GetAllUsuarios());
    }

    [HttpGet("api/usuario/{idUsuario}")]
    public ActionResult<Usuario> GetUsuarioByID(int id){
        return Ok(repository.GetUsuarioByID(id));
    }

    [HttpPut("api/usuario/{idUsuario}/nombre/{user}")]
    public ActionResult<Usuario> UpdateUsuario(Usuario usuario, int id){
        return Ok(repository.UpdateUsuario(usuario, id));
    }

    [HttpDelete("api/removeUsuario")]
    public ActionResult<bool> RemoveUsuario(int id){
        return Ok(repository.RemoveUsuario(id));
    }
}