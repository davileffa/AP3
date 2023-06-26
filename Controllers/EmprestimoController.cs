using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AP3.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AP3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILivroRepository _livroRepository;

        public EmprestimoController(IUsuarioRepository usuarioRepository, ILivroRepository livroRepository)
        {
            _usuarioRepository = usuarioRepository;
            _livroRepository = livroRepository;
        }

        [HttpPost]
        public IActionResult EmprestarLivro(EmprestimoViewModel emprestimoViewModel)
        {
            // Verifica se o usuário e o livro existem
            Usuario usuario = _usuarioRepository.GetById(emprestimoViewModel.UsuarioId);
            Livro livro = _livroRepository.GetById(emprestimoViewModel.LivroId);

            if (usuario == null || livro == null)
            {
                return BadRequest("Usuário ou livro não encontrado.");
            }

            // Implemente a lógica de empréstimo de livro aqui

            return Ok("Livro emprestado com sucesso.");
        }
    }
}
