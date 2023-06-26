using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AP3.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AP3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevolucaoController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILivroRepository _livroRepository;

        public DevolucaoController(IUsuarioRepository usuarioRepository, ILivroRepository livroRepository)
        {
            _usuarioRepository = usuarioRepository;
            _livroRepository = livroRepository;
        }

        [HttpPost]
        public IActionResult DevolverLivro(DevolucaoViewModel devolucaoViewModel)
        {
            // Verifica se o usuário e o livro existem
            Usuario usuario = _usuarioRepository.GetById(devolucaoViewModel.UsuarioId);
            Livro livro = _livroRepository.GetById(devolucaoViewModel.LivroId);

            if (usuario == null || livro == null)
            {
                return BadRequest("Usuário ou livro não encontrado.");
            }

            // Implemente a lógica de devolução de livro aqui

            return Ok("Livro devolvido com sucesso.");
        }
    }
}
